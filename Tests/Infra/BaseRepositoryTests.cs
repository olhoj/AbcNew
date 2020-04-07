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
    public class BaseRepositoryTests : AbstractClassTests<BaseRepository<Measure, MeasureData>, object>
    {
        private MeasureData data;
        private class testClass : BaseRepository<Measure, MeasureData>
        {
            public testClass(DbContext c, DbSet<MeasureData> s) : base(c, s) { }

            protected internal override Measure toDomainObject(MeasureData d) => new Measure(d);

            protected override async Task<MeasureData> getData(string id)
            {
                return await dbSet.FirstOrDefaultAsync(m => m.Id == id);
            }

            protected override string GetId(Measure entity) => entity?.Data?.Id;
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            var options = new DbContextOptionsBuilder<QuantityDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            var c = new QuantityDbContext(options);
            obj = new testClass(c, c.Measures);
            data = GetRandom.Object<MeasureData>(); 
        }

        [TestMethod]
        public void GetTest()
        {
            var count = GetRandom.UInt8(15, 30);
            var countBefore = obj.Get().GetAwaiter().GetResult().Count;
            for (var i = 0; i < count; i++)
            {
                data = GetRandom.Object<MeasureData>();
                AddTest();
            }
            Assert.AreEqual(count + countBefore, obj.Get().GetAwaiter().GetResult().Count);
        }

        [TestMethod]
        public void GetByIdTest() => AddTest();

        [TestMethod]
        public void DeleteTest()
        {
            AddTest();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
            obj.Delete(data.Id).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
        }

        [TestMethod]
        public void AddTest()
        {
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            Assert.IsNull(expected.Data);
            obj.Add(new Measure(data)).GetAwaiter();
            expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(data, expected.Data);
        }

        [TestMethod]
        public void UpdateTest()
        {
            AddTest();
            var newData = GetRandom.Object<MeasureData>();
            newData.Id = data.Id;
            obj.Update(new Measure(newData)).GetAwaiter();
            var expected = obj.Get(data.Id).GetAwaiter().GetResult();
            TestArePropertyValuesEqual(newData, expected.Data);
        }
    }
}
