using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Infra;
using Abc.Infra.Quantity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Infra
{
    [TestClass]
    public class PaginatedRepositoryTests : AbstractClassTests<PaginatedRepository<Measure, MeasureData>,
        FilteredRepository<Measure, MeasureData>>
    {
        private class testClass : PaginatedRepository<Measure, MeasureData>
        {

            public testClass(DbContext c, DbSet<MeasureData> s) : base(c, s) { }

            protected internal override Measure toDomainObject(MeasureData d) => new Measure(d);

            protected override async Task<MeasureData> getData(string id) => await dbSet.FirstOrDefaultAsync(m => m.Id == id);

            protected override string GetId(Measure entity) => entity?.Data?.Id;

        }

        private byte count;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();

            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new QuantityDbContext(options);
            obj = new testClass(c, c.Measures);
            count = GetRandom.UInt8(20, 40);
            foreach (var p in c.Measures)
                c.Entry(p).State = EntityState.Deleted;
            addItems();
        }
        [TestMethod]
        public void PageIndexTest()
        {
            IsProperty(() => obj.PageIndex, x => obj.PageIndex = x);
        }

        [TestMethod]
        public void TotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.TotalPages;
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void HasNextPageTest()
        {
            void testNextPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasNextPage;
                Assert.AreEqual(expected, actual);
            }
            testNextPage(0, true);
            testNextPage(1, true);
            testNextPage(GetRandom.Int32(2, obj.TotalPages - 1), true);
            testNextPage(obj.TotalPages, false);
        }

        [TestMethod]
        public void HasPreviousPageTest()
        {
            void testPreviousPage(int pageIndex, bool expected)
            {
                obj.PageIndex = pageIndex;
                var actual = obj.HasPreviousPage;
                Assert.AreEqual(expected, actual);
            }
            testPreviousPage(0, false);
            testPreviousPage(1, false);
            testPreviousPage(2, true);
            testPreviousPage(GetRandom.Int32(2, obj.TotalPages), true);
            testPreviousPage(obj.TotalPages, true);
        }

        [TestMethod]
        public void PageSizeTest()
        {
            Assert.AreEqual(5, obj.PageSize);
            IsProperty(() => obj.PageSize, x => obj.PageSize = x);
        }

        [TestMethod]
        public void GetTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.getTotalPages(obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void CountTotalPagesTest()
        {
            var expected = (int)Math.Ceiling(count / (double)obj.PageSize);
            var totalPagesCount = obj.countTotalPages(count, obj.PageSize);
            Assert.AreEqual(expected, totalPagesCount);
        }

        [TestMethod]
        public void GetItemsCountTest()
        {
            var itemsCount = obj.getItemsCount();
            Assert.AreEqual(count, itemsCount);
        }

        private void addItems()
        {
            for (var i = 0; i < count; i++)
                obj.Add(new Measure(GetRandom.Object<MeasureData>())).GetAwaiter();
        }

        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var o = obj.createSqlQuery();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void AddSkipAndTakeTest()
        {
            var sql = obj.createSqlQuery();
            var o = obj.addSkipAndTake(sql);
            Assert.IsNotNull(o);
        }
    }
}