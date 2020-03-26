using Abc.Data.Common;
using Abc.Domain.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Tests.Pages.Quantity
{
    public partial class MeasuresPageTests
    {
        internal class baseTestRepository<TObj, TData> 
            where TObj : Entity<TData>
            where TData : UniqueEntityData, new()
        {
            private readonly List<TObj> list;
            public baseTestRepository()
            {
                list = new List<TObj>();
            }
            public async Task Add(TObj obj)
            {
                await Task.CompletedTask;
                list.Add(obj);
            }

            public async Task Delete(string id)
            {
                await Task.CompletedTask;
                var obj = list.Find(x => x.Data.Id == id);
                list.Remove(obj);
            }

            public async Task<List<TObj>> Get()
            {
                await Task.CompletedTask;
                return list;
            }

            public async Task<TObj> Get(string id)
            {
                await Task.CompletedTask;
                return list.Find(x => x.Data.Id == id);
            }

            public async Task Update(TObj obj)
            {
                await Delete(obj.Data.Id);
                list.Add(obj);
            }
            public int PageIndex { get; set; }
            public int PageSize { get; set; }

            public int TotalPages => throw new System.NotImplementedException();

            public bool HasNextPage => throw new System.NotImplementedException();

            public bool HasPreviousPage => throw new System.NotImplementedException();

            public string SortOrder { get; set; }
            public string SearchString { get; set; }
            public string FixedFilter { get; set; }
            public string FixedValue { get; set; }

        }
    }
}
