using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Abc.Aids;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions {
    public static class DetailsTableForHtmlExtension {
        public static IHtmlContent DetailsTableFor<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, IList<TResult>>> expression, params Expression<Func<TResult, object>>[] properties) where TModel: PageModel{
            var htmlStrings = new List<object>();
            var f = expression.Compile();
            var items = f(htmlHelper.ViewData.Model);
            if (items.Count > 0) {
                htmlStrings.Add(new HtmlString("<dt class=\"col-sm-2\">"));
                htmlStrings.Add(htmlHelper.DisplayNameFor(expression));
                htmlStrings.Add(new HtmlString("</dt>"));
                htmlStrings.Add(new HtmlString("<p />"));
                htmlStrings.Add(new HtmlString("<dd class=\"col-sm-10\">"));
                htmlStrings.Add(new HtmlString("<table class=\"table\">"));
                htmlStrings.Add(new HtmlString("<thead>"));
                htmlStrings.Add(new HtmlString("<tr>"));
                foreach (var p in properties) {
                    htmlStrings.Add(new HtmlString("<th>"));
                    htmlStrings.Add(GetMember.DisplayName<TResult>(p));
                    htmlStrings.Add(new HtmlString("</th>"));
                }
                htmlStrings.Add(new HtmlString("</tr>"));
                htmlStrings.Add(new HtmlString("</thead>"));
                htmlStrings.Add(new HtmlString("<tbody>"));
                foreach (var e in items) {
                    htmlStrings.Add(new HtmlString("<tr>"));
                    foreach (var p in properties) {
                        htmlStrings.Add(new HtmlString("<td>"));
                        var x = p.Compile();
                        htmlStrings.Add(x(e).ToString());
                        htmlStrings.Add(new HtmlString("</td>"));
                    }
                    htmlStrings.Add(new HtmlString("</tr>"));
                }
                htmlStrings.Add(new HtmlString("</tbody>"));
                htmlStrings.Add(new HtmlString("</table>"));
                htmlStrings.Add(new HtmlString("</dd>"));
            };
            return new HtmlContentBuilder(htmlStrings);
        }

    }
}
