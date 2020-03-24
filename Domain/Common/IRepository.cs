using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Domain.Common
{
    public interface IRepository<T>:ICrudMethods<T>, IPaging, ISorting, IFiltering 
    {   

       
                
    }
}