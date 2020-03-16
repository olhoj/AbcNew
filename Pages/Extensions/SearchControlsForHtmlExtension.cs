using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions {
    public static class SearchControlsForHtmlExtension {
        internal const string backToFullList = "Back to full list";

        public static IHtmlContent SearchControlsFor(
            this IHtmlHelper htmlHelper, string filter, string linkToFullList, string text=backToFullList) {
            var htmlStrings = composeHtmlStrings(filter, linkToFullList, text);
            return new HtmlContentBuilder(htmlStrings);
        }

        internal static List<object> composeHtmlStrings(string filter, string linkToFullList, string text) {
            var htmlStrings = new List<object> {
                new HtmlString("<form asp-action=\"./Index\" method=\"get\">"),
                new HtmlString("<div class=\"form-inline col-md-6\">"),
                new HtmlString("Find by:"),
                new HtmlString("&nbsp;"),
                new HtmlString($"<input class=\"form-control\" type=\"text\" name=\"SearchString\" value=\"{filter}\" />"),
                new HtmlString("&nbsp;"),
                new HtmlString("<input type=\"submit\" value=\"Search\" class=\"btn btn-default\" />"),
                new HtmlString("&nbsp;"),
                new HtmlString($"<a href=\"{linkToFullList}\">{text}</a>"),
                new HtmlString("</div>"),
                new HtmlString("</form>")
            };
            return htmlStrings;
        }
    }
}
