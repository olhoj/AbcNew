using Abc.Data.Quantity;
using Abc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Domain.Quantity
{
    public class Measure : Entity<MeasureData>
    {
        public Measure() : this(null) { }
        public Measure(MeasureData data) : base(data) { }
    }
}
