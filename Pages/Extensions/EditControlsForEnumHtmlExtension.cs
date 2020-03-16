using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions {

    public static class EditControlsForEnumHtmlExtension {

        public static IHtmlContent EditControlsForEnum<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression) {
            
            var selectList = new SelectList(Enum.GetNames(typeof(TResult)));
            
            var htmlStrings = EditControlsForEnumHtmlExtension.htmlStrings(htmlHelper, expression, selectList);

            return new HtmlContentBuilder(htmlStrings);
        }

        private static List<object> htmlStrings<TModel, TResult>(IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression, SelectList selectList) {
            return new List<object> {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.DropDownListFor(expression, selectList, new {@class = "form-control"}),
                htmlHelper.ValidationMessageFor(expression, "", new {@class = "text-danger"}),
                new HtmlString("</div>")
            };
        }

    }

}