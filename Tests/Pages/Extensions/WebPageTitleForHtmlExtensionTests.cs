using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class WebPageTitleForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(WebPageTitleForHtmlExtension);

        [TestMethod]
        public void WebPageTitleForTest()
        {
            Assert.Inconclusive();
        }
    }
}