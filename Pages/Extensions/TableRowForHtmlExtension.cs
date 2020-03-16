using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions {
    public static class TableRowForHtmlExtension {
        public static IHtmlContent TableRowFor(
            this IHtmlHelper htmlHelper, string page, object index,
            params IHtmlContent[] values) {
            var htmlStrings = new List<object>();
            foreach (var value in values) AddValue(htmlStrings, value);
            htmlStrings.Add(new HtmlString("<td>"));
            htmlStrings.Add(new HtmlString($"<a href=\"{page}/Edit?id={index}\">{Constants.EditLinkTitle}</a>"));
            htmlStrings.Add(" | ");
            htmlStrings.Add(new HtmlString($"<a href=\"{page}/Details?id={index}\">{Constants.DetailsLinkTitle}</a>"));
            htmlStrings.Add(" | ");
            htmlStrings.Add(new HtmlString($"<a href=\"{page}/Delete?id={index}\">{Constants.DeleteLinkTitle}</a>"));
            htmlStrings.Add(new HtmlString("</td>"));
            return new HtmlContentBuilder(htmlStrings);
        }

        internal static void AddValue(List<object> htmlStrings, IHtmlContent value) {
            if (htmlStrings is null) return;
            if (value is null) return;
            htmlStrings.Add(new HtmlString("<td>"));
            htmlStrings.Add(value);
            htmlStrings.Add(new HtmlString("</td>"));
        }
    }
}
