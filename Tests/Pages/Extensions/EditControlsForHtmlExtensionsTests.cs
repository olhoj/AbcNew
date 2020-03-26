using System.Collections.Generic;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Abc.Pages.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class EditControlsForHtmlExtensionsTests : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize() => type = typeof(EditControlsForHtmlExtensions);

        [TestMethod]
        public void EditControlsForTest()
        {
            var obj = EditControlsForHtmlExtensions.EditControlsFor(new HtmlHelperMock<UnitView>(), x => x.MeasureId);
            Assert.IsInstanceOfType(obj, typeof(HtmlContentBuilder));
        }
        [TestMethod]
        public void HtmlStringsTest()
        {
            var expected = new List<string> { "<div class=\"form-group\">", "LabelFor", "EditorFor", "ValidationMessageFor", "</div>" };
            var actual = EditControlsForHtmlExtensions.htmlStrings(new HtmlHelperMock<MeasureView>(), x => x.Name);
            TestHtml.Strings(actual, expected);
        }
    }
}
