using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Measures
{
    public class CreateModel : MeasuresPage

    {
        public CreateModel(IMeasuresRepository r) : base(r) { }

        public IActionResult OnGet() => Page();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!await addObject()) return Page();
            return RedirectToPage("./Index");
        }
    }
}
