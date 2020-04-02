using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{
    public class UnitTerm : Entity<UnitTermData>
    {
        public UnitTerm() : this(null) { }
        public UnitTerm(UnitTermData data) : base(data) { }
    }
}
