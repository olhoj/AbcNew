using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

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
        public string ItemId { get => Item.Id; }

        public string CurrentSort { get; set; } = "Current Sort";
        public string CurrentFilter { get; set; } = "Current Filter";
        public string SearchString { get; set; }


        public int PageIndex { get => db.PageIndex; set => db.PageIndex = value; }
        public int TotalPages => db.TotalPages;
        public string PageTitle { get; set; }
        public string PageSubTitle { get; set; }
        public bool HasPreviousPage => db.HasPreviousPage;
        public bool HasNextPage => db.HasNextPage;


        protected internal async Task<bool> addObject()
            //TODO
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        {
            if (!ModelState.IsValid) return false;
            try { await db.Add(MeasureViewFactory.Create(Item)); }
            catch { return false; }
            return true;
        }
        protected internal async Task updateObject()
        {
            //TODO
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.

            await db.Update(MeasureViewFactory.Create(Item));
        }
        protected internal async Task getObject(string id)
        {

            var o = await db.Get(id);
            Item = MeasureViewFactory.Create(o);
        }
        protected internal async Task deleteObject(string id)
        {
            await db.Delete(id);
        }

        public string GetSortString(Expression<Func<MeasureData, object>> e, string page)
        {
            var name = GetMember.Name(e);
            string sortOrder;
            if (string.IsNullOrEmpty(CurrentSort)) sortOrder = name;
            if (!CurrentSort.StartsWith(name)) sortOrder = name;
            else if (CurrentSort.EndsWith("_desc")) sortOrder = name;
            else sortOrder = name + "_desc";
            return $"{page}?sortOrder={sortOrder}&currentFilter={CurrentFilter}";
        }

        protected internal async Task getList(string sortOrder, string currentFilter, string searchString, int? pageIndex)
        {
            sortOrder = string.IsNullOrEmpty(sortOrder) ? "Name" : sortOrder;
            CurrentSort = sortOrder;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            db.SortOrder = sortOrder;
            SearchString = CurrentFilter;
            db.SearchString = SearchString;
            PageIndex = pageIndex ?? 1;
            var l = await db.Get();
            Items = new List<MeasureView>();
            foreach (var e in l) Items.Add(MeasureViewFactory.Create(e));
        }
    }
}
