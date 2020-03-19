using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions
{
    public static class DisplayControlsForHtmlExtension
    {
        public static IHtmlContent DisplayControlsFor<TModel, TResult>(
            this IHtmlHelper<TModel>htmlHelper, Expression<Func<TModel, TResult>>expression)
        {
            var s = htmlStrings(htmlHelper, expression);

            return new HtmlContentBuilder(s);
        }
        public static IHtmlContent DisplayControlsFor<TModel, TResult>(this IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TResult>> expression, string value)
        {
            var s = htmlStrings(htmlHelper, expression, value);

            return new HtmlContentBuilder(s);
        }

        internal static List<object> htmlStrings<TClassType, TPropertyType>(
            IHtmlHelper<TClassType> htmlHelper, 
            Expression<Func<TClassType, TPropertyType>> expression)
        {
            return new List<object>
            {
                new HtmlString("<dt class=\"col-sm-2\">"),
                htmlHelper.DisplayNameFor(expression),
                new HtmlString("</dt>"),
                new HtmlString("<dd class=\"col-sm-10\">"),
                htmlHelper.DisplayFor(expression),
                new HtmlString("</dd>")
            };
        }

        private static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, string value)
        {
            return new List<object>
            {
                new HtmlString("<dt class=\"col-sm-2\">"),
                htmlHelper.DisplayNameFor(expression),
                new HtmlString("</dt>"),
                new HtmlString("<dd class=\"col-sm-10\">"),
                htmlHelper.Raw(value),
                new HtmlString("</dd>")
            };
        }
    }
}
