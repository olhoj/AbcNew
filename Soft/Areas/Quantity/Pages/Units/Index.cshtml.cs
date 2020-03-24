using System.Threading.Tasks;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Abc.Soft.Areas.Quantity.Pages.Units
{
    public class IndexModel : UnitsPage
    {
        public IndexModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}

