using Abc.Data.Common;

namespace Abc.Domain.Common
{
    public abstract class Entity<T> where T : PeriodData

    {
        public T Data { get; internal set; }

        protected Entity(T data)
        {
            Data = data;
        }

    }
}
