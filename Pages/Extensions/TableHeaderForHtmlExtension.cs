using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions {

    public static class TableHeaderForHtmlExtension {

        public static IHtmlContent TableHeaderFor(
            this IHtmlHelper htmlHelper,
            params string[] names) {
            var htmlStrings = new List<object> {new HtmlString("<tr>")};
            foreach (var name in names) AddHeader(htmlStrings, name);
            htmlStrings.Add(new HtmlString("<th></th>"));
            htmlStrings.Add(new HtmlString("</tr>"));

            return new HtmlContentBuilder(htmlStrings);
        }

        public static IHtmlContent TableHeaderFor(
           this IHtmlHelper htmlHelper, 
           params Link[] attributes) {
            var htmlStrings = new List<object> {new HtmlString("<tr>")};
            foreach (var attribute in attributes) AddLink(htmlStrings, attribute);
            htmlStrings.Add(new HtmlString("<th></th>"));
            htmlStrings.Add(new HtmlString("</tr>"));

            return new HtmlContentBuilder(htmlStrings);
        }

        internal static void AddHeader(List<object> htmlStrings, string name) {
            if (htmlStrings is null) return;
            if (name is null) return;
            htmlStrings.Add(new HtmlString("<th>"));
            htmlStrings.Add(name);
            htmlStrings.Add(new HtmlString("</th>"));
        }
        internal static void AddLink(List<object> htmlStrings, Link link) {
            if (htmlStrings is null) return;
            if (link is null) return;
            htmlStrings.Add(new HtmlString("<th>"));
            htmlStrings.Add(new HtmlString($"<a href=\"{link.Url}\"><span style=\"font-weight:normal\">{link.DisplayName}</span></a>"));
            htmlStrings.Add(new HtmlString("</th>"));
        }

    }

}
