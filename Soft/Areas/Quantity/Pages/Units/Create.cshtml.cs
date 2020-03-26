using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class CreateModel : UnitsPage

    {
        public CreateModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m) { }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
