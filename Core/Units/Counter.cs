using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Counter {

        public static Data Measure = new Data("Counter");

        public static List<Data> Units =>
            new List<Data> {
                new Data(unitName, 1),
                new Data(decaUnitName, Factors.Deca),
                new Data(hectoUnitName, Factors.Hecto),
                new Data(kiloUnitName, Factors.Kilo),
                new Data(megaUnitName, Factors.Mega),
                new Data(gigaUnitName, Factors.Giga),
                new Data(teraUnitName, Factors.Tera)
            };
        internal const string unitName = "Units";
        internal const string decaUnitName = "DecaUnits";
        internal const string hectoUnitName = "HectoUnits";
        internal const string kiloUnitName = "KiloUnits";
        internal const string megaUnitName = "MegaUnits";
        internal const string gigaUnitName = "GigaUnits";
        internal const string teraUnitName = "TeraUnits";

    }

}
