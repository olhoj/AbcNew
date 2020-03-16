using Abc.Domain.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage: PageModel
    {
        protected internal readonly IMeasuresRepository db;

        protected internal MeasuresPage(IMeasuresRepository r)
        { 
            db = r;
            PageTitle = "Measures";
        
        }


        
        [BindProperty]
        public MeasureView Item { get; set; }
        public IList<MeasureView> Items { get; set; }

        public string CurrentSort { get; set; } = "Current Sort";

        public string CurrentFilter { get; set; } = "Current Filter";


        public int PageIndex { get; set; } = 3;

        public int TotalPages { get; set; } = 10;

        public string PageTitle { get; set; }
        public string ItemId { get => Item.Id; }

        public string PageSubTitle { get; set; }

    }
}
