using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class SearchControlsForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(SearchControlsForHtmlExtension);

        [TestMethod]
        public void SearchControlsForTest()
        {
            Assert.Inconclusive();
        }
    }
}