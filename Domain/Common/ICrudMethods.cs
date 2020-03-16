using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Domain.Common
{
    public interface ICrudMethods<T>
    {
        Task<List<T>> Get();

        Task<T> Get(string Id);
        Task Delete(string Id);

        Task Add(T obj);
        Task Update(T obj);

    }
}