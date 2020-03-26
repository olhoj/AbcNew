using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Abc.Aids;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Abc.Tests
{
    internal class HtmlHelperMock<TModel> : IHtmlHelper<TModel>
    {
        public IHtmlContent ActionLink(string linkText, string actionName, string controllerName, string protocol, string hostname,
            string fragment, object routeValues, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent AntiForgeryToken()
        {
            throw new NotImplementedException();
        }

        public MvcForm BeginForm(string actionName, string controllerName, object routeValues, FormMethod method, bool? antiforgery,
            object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public MvcForm BeginRouteForm(string routeName, object routeValues, FormMethod method, bool? antiforgery,
            object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent CheckBox(string expression, bool? isChecked, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent Display(string expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            throw new NotImplementedException();
        }

        public string DisplayName(string expression)
        {
            throw new NotImplementedException();
        }

        public string DisplayText(string expression)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent DropDownList(string expression, IEnumerable<SelectListItem> selectList, string optionLabel, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent Editor(string expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            throw new NotImplementedException();
        }

        string IHtmlHelper<TModel>.Encode(object value)
        {
            throw new NotImplementedException();
        }

        string IHtmlHelper<TModel>.Encode(string value)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent HiddenFor<TResult>(Expression<Func<TModel, TResult>> expression, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public string IdFor<TResult>(Expression<Func<TModel, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent LabelFor<TResult>(Expression<Func<TModel, TResult>> e,
            string labelText, object htmlAttributes) => new HtmlContentMock($"LabelFor{GetMember.Name(e)}");
        public IHtmlContent ListBoxFor<TResult>(Expression<Func<TModel, TResult>> expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public string NameFor<TResult>(Expression<Func<TModel, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent PasswordFor<TResult>(Expression<Func<TModel, TResult>> expression, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent RadioButtonFor<TResult>(Expression<Func<TModel, TResult>> expression, object value, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        IHtmlContent IHtmlHelper<TModel>.Raw(object value)
        {
            throw new NotImplementedException();
        }

        IHtmlContent IHtmlHelper<TModel>.Raw(string value)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent TextAreaFor<TResult>(Expression<Func<TModel, TResult>> e, int rows, int columns, object htmlAttributes)
            => new HtmlContentMock("TextAreaFor");

        public IHtmlContent TextBoxFor<TResult>(Expression<Func<TModel, TResult>> e, string format, object htmlAttributes)
            => new HtmlContentMock("TextBoxFor");

        public IHtmlContent ValidationMessageFor<TResult>(Expression<Func<TModel, TResult>> e, string message, object htmlAttributes, string tag)
            => new HtmlContentMock("ValidationMessageFor");


        public string ValueFor<TResult>(Expression<Func<TModel, TResult>> e, string format)
            => "ValueFor";

        public ViewDataDictionary<TModel> ViewData { get; } = null;

        public IHtmlContent CheckBoxFor(Expression<Func<TModel, bool>> expression, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent DisplayFor<TResult>(Expression<Func<TModel, TResult>> expression, string templateName, string htmlFieldName,
            object additionalViewData)
        {
            throw new NotImplementedException();
        }

        public string DisplayNameForInnerType<TModelItem, TResult>(Expression<Func<TModelItem, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public string DisplayNameFor<TResult>(Expression<Func<TModel, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public string DisplayTextFor<TResult>(Expression<Func<TModel, TResult>> expression)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent DropDownListFor<TResult>(Expression<Func<TModel, TResult>> expression, IEnumerable<SelectListItem> selectList, string optionLabel,
            object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent EditorFor<TResult>(Expression<Func<TModel, TResult>> expression, string templateName, string htmlFieldName,
            object additionalViewData) => new HtmlContentMock("EditorFor");


        string IHtmlHelper.Encode(object value)
        {
            throw new NotImplementedException();
        }

        string IHtmlHelper.Encode(string value)
        {
            throw new NotImplementedException();
        }

        public void EndForm()
        {
            
        }

        public string FormatValue(object value, string format)
        {
            throw new NotImplementedException();
        }

        public string GenerateIdFromName(string fullName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetEnumSelectList(Type enumType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetEnumSelectList<TEnum>() where TEnum : struct
        {
            throw new NotImplementedException();
        }

        public IHtmlContent Hidden(string expression, object value, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public string Id(string expression)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent Label(string expression, string labelText, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent ListBox(string expression, IEnumerable<SelectListItem> selectList, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public string Name(string expression)
        {
            throw new NotImplementedException();
        }

        public async Task<IHtmlContent> PartialAsync(string partialViewName, object model, ViewDataDictionary viewData)
        {
            await Task.CompletedTask;
            return new HtmlContentMock("PartialAsync");
        }

        public IHtmlContent Password(string expression, object value, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent RadioButton(string expression, object value, bool? isChecked, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        IHtmlContent IHtmlHelper.Raw(object value) => null;

        IHtmlContent IHtmlHelper.Raw(string value)
        {
            throw new NotImplementedException();
        }

        public async Task RenderPartialAsync(string partialViewName, object model, ViewDataDictionary viewData)
        {
            await Task.CompletedTask;
        }

        public IHtmlContent RouteLink(string linkText, string routeName, string protocol, string hostName, string fragment,
            object routeValues, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent TextArea(string expression, string value, int rows, int columns, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent TextBox(string expression, object value, string format, object htmlAttributes)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent ValidationMessage(string expression, string message, object htmlAttributes, string tag)
        {
            throw new NotImplementedException();
        }

        public IHtmlContent ValidationSummary(bool excludePropertyErrors, string message, object htmlAttributes, string tag)
        {
            throw new NotImplementedException();
        }

        public string Value(string expression, string format)
        {
            throw new NotImplementedException();
        }

        public Html5DateRenderingMode Html5DateRenderingMode { get; set; }
        public string IdAttributeDotReplacement { get; } = null;
        public IModelMetadataProvider MetadataProvider { get; } = null;
        public ITempDataDictionary TempData { get; } = null;
        public UrlEncoder UrlEncoder { get; } = null;
        public dynamic ViewBag { get; } = null;
        public ViewContext ViewContext { get; } = null;
        ViewDataDictionary IHtmlHelper.ViewData => ViewData;
    }
}