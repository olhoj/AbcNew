using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class HypertextLinkForHtmlExtensionsTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(HypertextLinkForHtmlExtension);

        [TestMethod]
        public void HypertextLinkForTest()
        {
            Assert.Inconclusive();
        }
    }
}