using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public static class UnitTermViewFactory
    {
        public static UnitTerm Create(UnitTermView view)
        {
            var d = new UnitTermData();
            Copy.Members(view, d);
            return new UnitTerm(d);
        }

        public static UnitTermView Create(UnitTerm obj)
        {
            var v = new UnitTermView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
