using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft
{
    public class EditModel : MeasuresPage
    {
        public EditModel(IMeasuresRepository r) : base(r){}

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            await updateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }
}
