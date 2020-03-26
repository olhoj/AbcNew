using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft
{
    public class DeleteModel : MeasuresPage
    {
        public DeleteModel(IMeasuresRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id, string fixedFilter, string fixedValue)
        {
            await deleteObject(id, fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }
    }
}
