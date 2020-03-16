using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Abc.Domain.Quantity;
using Abc.Soft.Data;
using Abc.Pages.Quantity;
using Abc.Facade.Quantity;

namespace Abc.Soft
{
    public class EditModel : MeasuresPage
    {
        public EditModel(IMeasuresRepository r) : base(r){}

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)return NotFound();
            
            Item= MeasureViewFactory.Create(await db.Get(id));

            if (Item == null) return NotFound();
            
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)return Page();

            await db.Update(MeasureViewFactory.Create(Item));
            
            return RedirectToPage("./Index");
        }

    }
}
