using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public static class UnitViewFactory
    {
        public static Unit Create(UnitView v)
        {
            var o = new Unit { 
                Data =
                {
                Id = v.Id,
                Name = v.Name,
                Code = v.Code,
                Definition = v.Definition,
                ValidFrom = v.ValidFrom,
                ValidTo = v.ValidTo
                }
            };

            return o;
        }

        public static UnitView Create(Unit o)
        {
            var v = new UnitView
            {
                Id = o.Data.Id,
                Name = o.Data.Name,
                Code = o.Data.Code,
                Definition = o.Data.Definition,
                ValidFrom = o.Data.ValidFrom,
                ValidTo = o.Data.ValidTo
            };

            return v;
        }
    }
}
