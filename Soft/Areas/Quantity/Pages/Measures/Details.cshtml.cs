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
    public class DetailsModel : MeasuresPage

    {
        public DetailsModel(IMeasuresRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);
            return Page();
        }
    }
}
