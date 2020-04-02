using Abc.Aids;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public static class UnitViewFactory
    {
        public static Unit Create(UnitView v)
        {
            var o = new Unit();
            Copy.Members(v,o.Data);
            return o;
        }
        public static UnitView Create(Unit o)
        {
            var v = new UnitView();
            Copy.Members(o.Data, v);
            return v;
        }
    }
}
