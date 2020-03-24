using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class EditModel : UnitsPage
    {
        public EditModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m){}

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            await getObject(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            await updateObject();
            return Redirect($"/Quantity/Units/Index?fixedFilter={FixedFilter}&fixedValue={FixedValue}");
        }

    }
}
