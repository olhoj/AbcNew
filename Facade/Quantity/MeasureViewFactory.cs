using Abc.Aids;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public static class MeasureViewFactory
    {
        public static Measure Create(MeasureView v)
        {
            var o = new Measure();
            Copy.Members(v, o.Data);
            return o;
        }
        public static MeasureView Create(Measure o)
        {
            var v = new MeasureView();
            Copy.Members(o.Data, v);
            return v;
        }
    }
}
