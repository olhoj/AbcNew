using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class TableRowForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(TableRowForHtmlExtension);

        [TestMethod]
        public void TableRowForTest()
        {
            Assert.Inconclusive();
        }
    }
}