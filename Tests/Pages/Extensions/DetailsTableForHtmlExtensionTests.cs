using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class DetailsTabelForHtmlExtensionTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(DetailsTableForHtmlExtension);

        [TestMethod]
        public void DetailsTableForTest()
        {
            Assert.Inconclusive();
        }
    }
}
