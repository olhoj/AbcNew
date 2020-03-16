using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions {

    public static class HypertextLinkForHtmlExtension {

        public static IHtmlContent HypertextLinkFor(
            this IHtmlHelper htmlHelper, string text, params Link[] items) {
            var htmlStrings = new List<object> {
                new HtmlString("<p>"),
                new HtmlString($"<a>{text}</a>")
            };

            htmlStrings.AddRange(
                items.Select(item => new HtmlString($"<a> </a><a href=\"{item.Url}\">{item.DisplayName}</a>")));

            htmlStrings.Add(new HtmlString("</p>"));

            return new HtmlContentBuilder(htmlStrings);
        }

    }

}
