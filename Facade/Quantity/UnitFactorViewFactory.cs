using System;
using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public static class UnitFactorViewFactory
    {
        public static UnitFactor Create(UnitFactorView view)
        {
            var d = new UnitFactorData();
            Copy.Members(view, d);
            return new UnitFactor(d);
        }

        public static UnitFactorView Create(UnitFactor obj)
        {
            var v = new UnitFactorView();
            Copy.Members(obj.Data, v);
            return v;
        }
    }
}
