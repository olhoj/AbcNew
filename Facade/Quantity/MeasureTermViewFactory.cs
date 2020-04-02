using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public static class MeasureTermViewFactory
    {
        public static MeasureTerm Create(MeasureTermView view)
        {
            var d = new MeasureTermData();
            Copy.Members(view, d);
            return new MeasureTerm(d);
        }

        public static MeasureTermView Create(MeasureTerm obj)
        {
            var v = new MeasureTermView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
