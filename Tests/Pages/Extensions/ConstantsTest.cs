using Abc.Pages.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Tests.Pages.Extensions
{
    [TestClass]
    public class ConstantsTest : BaseTests
    {
        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(Constants);
        }

        [TestMethod] public void UnspecifiedTest() => Assert.AreEqual("Unspecified", Constants.Unspecified);

        [TestMethod] public void CreateNewLinkTitleTest() => Assert.AreEqual("Create New", Constants.CreateNewLinkTitle);
        [TestMethod] public void EditLinkTitleTest() => Assert.AreEqual("Edit", Constants.EditLinkTitle);
        [TestMethod] public void DetailsLinkTitleTest() => Assert.AreEqual("Details", Constants.DetailsLinkTitle);
        [TestMethod] public void DeleteLinkTitleTest() => Assert.AreEqual("Delete", Constants.DeleteLinkTitle);

        [TestMethod] public void BusinessMenuTitleTest() => Assert.AreEqual("Business", Constants.BusinessMenuTitle);
        [TestMethod] public void PartiesMenuTitleTest() => Assert.AreEqual("Parties", Constants.PartiesPageTitle);
        [TestMethod] public void DataMenuTitleTest() => Assert.AreEqual("Data", Constants.DataMenuTitle);

        [TestMethod] public void CountriesPageTitleTest() => Assert.AreEqual("Countries", Constants.CountriesPageTitle);
        [TestMethod] public void MeasuresPageTitleTest() => Assert.AreEqual("Measures", Constants.MeasuresPageTitle);
        [TestMethod] public void OrdersPageTitleTest() => Assert.AreEqual("Orders", Constants.OrdersPageTitle);
        [TestMethod] public void PaymentsPageTitleTest() => Assert.AreEqual("Payments", Constants.PaymentsPageTitle);
        [TestMethod] public void InventoryPageTitleTest() => Assert.AreEqual("Inventory", Constants.InventoryPageTitle);
        [TestMethod] public void CataloguesPageTitleTest() => Assert.AreEqual("Cataloques", Constants.CataloguesPageTitle);
        [TestMethod] public void ProductsPageTitleTest() => Assert.AreEqual("Products", Constants.ProductsPageTitle);
        [TestMethod] public void ProcessesPageTitleTest() => Assert.AreEqual("Processes", Constants.ProcessesPageTitle);
        [TestMethod] public void ProceduresPageTitleTest() => Assert.AreEqual("Procedures", Constants.ProceduresPageTitle);
        [TestMethod] public void ProductTypesPageTitleTest() => Assert.AreEqual("Product Types", Constants.ProductTypesPageTitle);
        [TestMethod] public void RulesPageTitleTest() => Assert.AreEqual("Rules", Constants.RulesPageTitle);
        [TestMethod] public void RuleSetsPageTitleTest() => Assert.AreEqual("Rule Sets", Constants.RuleSetsPageTitle);
        [TestMethod] public void RuleContextsPageTitleTest() => Assert.AreEqual("Rule Contexts", Constants.RuleContextsPageTitle);
        [TestMethod] public void RuleOverridesPageTitleTest() => Assert.AreEqual("Rule Overrides", Constants.RuleOverridesPageTitle);
        [TestMethod] public void PartiesPageTitleTest() => Assert.AreEqual("Parties", Constants.PartiesPageTitle);
        [TestMethod] public void RolesPageTitleTest() => Assert.AreEqual("Roles", Constants.RolesPageTitle);
        [TestMethod] public void RelationsPageTitleTest() => Assert.AreEqual("Relations", Constants.RelationsPageTitle);
        [TestMethod] public void PartyContactsPageTitleTest() => Assert.AreEqual("Party Contacts", Constants.PartyContactsPageTitle);
        [TestMethod] public void PartyTypesPageTitleTest() => Assert.AreEqual("Party Types", Constants.PartyTypesPageTitle);
        [TestMethod] public void RoleTypesPageTitleTest() => Assert.AreEqual("Role Types", Constants.RoleTypesPageTitle);
        [TestMethod] public void RelationTypesPageTitleTest() => Assert.AreEqual("Relation Types", Constants.RelationTypesPageTitle);
        [TestMethod] public void SystemsOfUnitsPageTitleTest() => Assert.AreEqual("Systems Of Units", Constants.SystemsOfUnitsPageTitle);
        [TestMethod] public void UnitsPageTitleTest() => Assert.AreEqual("Units", Constants.UnitsPageTitle);
        [TestMethod] public void CurrenciesPageTitleTest() => Assert.AreEqual("Currencies", Constants.CurrenciesPageTitle);
        [TestMethod] public void RateTypesPageTitleTest() => Assert.AreEqual("Rate Types", Constants.RateTypesPageTitle);
        [TestMethod] public void RatesPageTitleTest() => Assert.AreEqual("Day Rates", Constants.RatesPageTitle);
        [TestMethod] public void PaymentMethodsPageTitleTest() => Assert.AreEqual("Payment Methods", Constants.PaymentMethodsPageTitle);
        [TestMethod] public void CalculatorPageTitleTest() => Assert.AreEqual("Calculator", Constants.CalculatorPageTitle);
    }
}
