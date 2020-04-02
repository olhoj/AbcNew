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
    public class FilteredRepositoryTests : AbstractClassTests<FilteredRepository<Measure, MeasureData>,
        SortedRepository<Measure, MeasureData>>
    {
        private class testClass : FilteredRepository<Measure, MeasureData>
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
        }

        [TestMethod]
        public void SearchStringTest()
            => IsNullableProperty(() => obj.SearchString, x => obj.SearchString = x);

        [TestMethod]
        public void FixedFilterTest()
            => IsNullableProperty(() => obj.FixedFilter, x => obj.FixedFilter = x);

        [TestMethod]
        public void FixedValueTest()
            => IsNullableProperty(() => obj.FixedValue, x => obj.FixedValue = x);

        [TestMethod]
        public void CreateSqlQueryTest()
        {
            var sql = obj.createSqlQuery();
            Assert.IsNotNull(sql);
        }

        [TestMethod]
        public void AddFixedFilteringTest()
        {
            var sql = obj.createSqlQuery();
            var fixedFilter = GetMember.Name<MeasureData>(x => x.Definition);
            obj.FixedFilter = fixedFilter;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var sqlNew = obj.addFixedFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void CreateFixedWhereExpressionTest()
        {
            var properties = typeof(MeasureData).GetProperties();
            var idx = GetRandom.Int32(0, properties.Length);
            var p = properties[idx];
            obj.FixedFilter = p.Name;
            var fixedValue = GetRandom.String();
            obj.FixedValue = fixedValue;
            var e = obj.createFixedWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            var expected = p.Name;
            if (p.PropertyType != typeof(string))
                expected += ".ToString()";
            expected += $".Contains(\"{fixedValue}\")";
            Assert.IsTrue(s.Contains(expected));
        }

        [TestMethod]
        public void CreateFixedWhereExpressionOnFidexFilterNullTest()
        {
            Assert.IsNull(obj.createFixedWhereExpression());
            obj.FixedValue = GetRandom.String();
            obj.FixedFilter = GetRandom.String();
            Assert.IsNull(obj.createFixedWhereExpression());
        }

        [TestMethod]
        public void AddFilteringTest()
        {
            var sql = obj.createSqlQuery();
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var sqlNew = obj.addFiltering(sql);
            Assert.IsNotNull(sqlNew);
        }

        [TestMethod]
        public void CreateWhereExpressionTest()
        {
            var searchString = GetRandom.String();
            obj.SearchString = searchString;
            var e = obj.createWhereExpression();
            Assert.IsNotNull(e);
            var s = e.ToString();

            foreach (var p in typeof(MeasureData).GetProperties())
            {
                var expected = p.Name;
                if (p.PropertyType != typeof(string))
                    expected += ".ToString()";
                expected += $".Contains(\"{searchString}\")";
                Assert.IsTrue(s.Contains(expected));
            }
        }
        [TestMethod]
        public void CreateWhereExpressionWithNullSearchStringTest()
        {
            obj.SearchString = null;
            var e = obj.createWhereExpression();
            Assert.IsNull(e);
        }
    }
}