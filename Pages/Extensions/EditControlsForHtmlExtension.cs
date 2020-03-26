using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Abc.Pages.Extensions
{
    public static class EditControlsForHtmlExtensions
    {
        public static IHtmlContent EditControlsFor<TClassType, TPropertyType>(

            this IHtmlHelper<TClassType> htmlHelper, Expression<Func<TClassType, TPropertyType>> expression)
        {
            var s = htmlStrings(htmlHelper, expression);
            return new HtmlContentBuilder(s);
        }

        internal static List<object> htmlStrings<TClassType, TPropertyType>(IHtmlHelper<TClassType> htmlHelper,
            Expression<Func<TClassType, TPropertyType>> expression)
        {
            return new List<object>
            {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.EditorFor(expression, new {htmlAttributes = new {@class = "form-control"}}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };
        }
    }
}

