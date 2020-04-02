using Abc.Data.Quantity;
using Abc.Domain.Common;

namespace Abc.Domain.Quantity
{
    public class MeasureTerm: Entity<MeasureTermData>
    {
        public MeasureTerm() : this(null) { }
        public MeasureTerm(MeasureTermData data) : base(data) { }
    }
}
