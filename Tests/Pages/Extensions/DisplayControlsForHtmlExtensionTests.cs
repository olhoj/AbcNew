using System.Collections.Generic;
using Abc.Facade.Quantity;
using Abc.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Extensions {

    [TestClass] public class DisplayControlsForHtmlExtensionTests : BaseTests {

        [TestInitialize] public virtual void TestInitialize() => type = typeof(DisplayControlsForHtmlExtension);

        [TestMethod] public void DisplayControlsForTest() {
            var obj = new HtmlHelperMock<UnitView>().DisplayControlsFor(x => x.MeasureId);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }

        [TestMethod] public void HtmlStringsTest() {
            var expected = new List<string> {"<dt", "DisplayNameFor", "</dt>", "<dd", "DisplayFor", "</dd>"};
            var actual =
                DisplayControlsForHtmlExtension.htmlStrings(new HtmlHelperMock<MeasureView>(), x => x.ValidFrom);
            TestHtml.Strings(actual, expected);
        }

    }

}