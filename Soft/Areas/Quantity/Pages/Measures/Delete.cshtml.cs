using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Domain.Quantity;
using Abc.Soft.Data;
using Abc.Pages.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft
{
    public class DeleteModel : MeasuresPage
    {
        public DeleteModel(IMeasuresRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();
            

            Item = MeasureViewFactory.Create(await db.Get(id));

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null) return NotFound();
            
            await db.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}
