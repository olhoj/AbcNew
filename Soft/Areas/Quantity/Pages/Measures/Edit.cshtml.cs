using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft
{
    public class EditModel : MeasuresPage
    {
        public EditModel(IMeasuresRepository r) : base(r){}

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await getObject(id);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await updateObject();
            return RedirectToPage("./Index");
        }

    }
}
