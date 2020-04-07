using System;
using Abc.Aids;
using Abc.Data.Common;
using Abc.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra
{
    [TestClass]
    public abstract class RepositoryTests<TRepository, TObject, TData> : BaseTests
    where TRepository : IRepository<TObject>
    where TObject : Entity<TData>
    where TData : PeriodData, new()
    {
        protected TData data;
        protected TRepository obj;
        protected DbContext db;
        protected int count;
        protected DbSet<TData> dbSet;

        public virtual void TestInitialize()
        {
            type = typeof(TRepository);
            data = GetRandom.Object<TData>();
            count = GetRandom.UInt8(20, 40);
            cleanDbSet();
            addItems();
        }
        protected void testGetList()
        {
            obj.PageIndex = GetRandom.Int32(2, obj.TotalPages - 1);
            var l = obj.Get().GetAwaiter().GetResult();
            Assert.AreEqual(obj.PageSize, l.Count);
        }

        [TestCleanup]
        public void TestCleanup() => cleanDbSet();

        protected void cleanDbSet()
        {
            foreach (var p in dbSet)
                db.Entry(p).State = EntityState.Deleted;
            db.SaveChanges();
        }

        protected void addItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(getObject(GetRandom.Object<TData>())).GetAwaiter();
        }

        [TestMethod]
        public void IsSealed() => Assert.IsTrue(type.IsSealed);

        [TestMethod]
        public void IsInherited() => Assert.AreEqual(getBaseType().Name, type?.BaseType?.Name);

        protected abstract Type getBaseType();

        [TestMethod]
        public void GetTest() => testGetList();

        [TestMethod]
        public void GetByIdTest() => AddTest();

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var id = getId(data);
            var expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
            obj.Delete(id).GetAwaiter();
            expected = obj.Get(id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
        }

        protected abstract string getId(TData d);

        [TestMethod]
        public void AddTest()
        {
            var id = getId(data);
            var expected = obj.Get(id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
            obj.Add(getObject(data)).GetAwaiter();
            expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
        }

        protected abstract TObject getObject(TData d);

        [TestMethod]
        public void UpdateTest()
        {
            AddTest();
            var id = getId(data);
            var newData = GetRandom.Object<TData>();
            setId(newData, id);
            obj.Update(getObject(newData)).GetAwaiter();
            var expected = obj.Get(id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(newData, expected.Data);
        }

        protected abstract void setId(TData d, string id);
    }
}