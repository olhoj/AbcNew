using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class DetailsModel : UnitsPage

    {
        public DetailsModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
