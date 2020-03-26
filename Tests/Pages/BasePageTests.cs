using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Abc.Tests.Pages.Quantity.MeasuresPageTests;

namespace Abc.Tests.Pages
{
    [TestClass]
    public class BasePageTests : AbstractClassTests<BasePage<IMeasuresRepository, Measure, MeasureView, MeasureData>,
        PageModel>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass(new testRepository());
        }

        private class testClass : BasePage<IMeasuresRepository, Measure, MeasureView, MeasureData>
        {
            protected internal testClass(IMeasuresRepository r) : base(r) => PageTitle = "Measures";

            public override string ItemId => Item?.Id ?? string.Empty;

            protected internal override string getPageUrl() => "/Quantity/Measures";

            protected internal override Measure toObject(MeasureView view) => MeasureViewFactory.Create(view);

            protected internal override MeasureView toView(Measure obj) => MeasureViewFactory.Create(obj);
        }
        private class testRepository : baseTestRepository<Measure, MeasureData>, IMeasuresRepository { }

        [TestMethod]
        public void CreateBasePageWithRepositoryTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ItemTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void ItemsTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void ItemIdTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void PageTitleTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void PageSubTitleTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void IndexUrlTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void GetIndexUrlTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void PageUrlTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void GetPageUrlTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void GetPageSubTitleTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void FixedValueTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FixedFilterTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void SortOrderTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void SearchStringTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void PageIndexTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void HasPreviousPageTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void HasNextPageTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void TotalPagesTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void AddObjectTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void ToObjectTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void UpdateObjectTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetObjectTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void ToViewTest()
        {
            Assert.Inconclusive();
        }
        [TestMethod]
        public void DeleteObjectTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetSortStringTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetListTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetSearchStringTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void GetListNoParamsTest()
        {
            Assert.Inconclusive();
        }


    }
}

    
