using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Quantity
{
    public class UnitsPage : BasePage<IUnitsRepository, Unit, UnitView, UnitData>
    {
        protected internal UnitsPage(IUnitsRepository r, IMeasuresRepository m) : base(r)
        {
            PageTitle = "Units";
            Measures = createMeasures(m);
        }

        private static IEnumerable<SelectListItem> createMeasures(IMeasuresRepository r)
        {
            var list = new List<SelectListItem>();
            var measures = r.Get().GetAwaiter().GetResult();
            foreach (var m in measures)
            {
                list.Add(new SelectListItem(m.Data.Name, m.Data.Id));
            }
            return list;
        }

        public IEnumerable<SelectListItem> Measures { get; }

        public override string ItemId => Item.Id;
        protected internal override string getPageSubtitle()
        {
            return FixedValue is null ? base.getPageSubtitle() : $"For {GetMeasureName(FixedValue)}";
        }

        protected internal override Unit toObject(UnitView view)
        {
            return UnitViewFactory.Create(view);
        }

        protected internal override UnitView toView(Unit obj)
        {
            return UnitViewFactory.Create(obj);
        }

        public string GetMeasureName(string measureId)
        {
            foreach (var m in Measures)
                if (m.Value == measureId) 
                    return m.Value;
            return "Unspecified";
        }
    }
}
