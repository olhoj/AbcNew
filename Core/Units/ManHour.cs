using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class ManHour {

        public static Data Measure = new Data("ManHour");

        public static List<Data> Units =>
            new List<Data> {
                new Data(manHourName, 1),
                new Data(decaManHourName, Factors.Deca),
                new Data(hectoManHourName, Factors.Hecto),
                new Data(kiloManHourName, Factors.Kilo),
                new Data(megaManHourName, Factors.Mega),
                new Data(gigaManHourName, Factors.Giga),
                new Data(teraManHourName, Factors.Tera),
                new Data(manDayName, 8),
                new Data(manWeekName, 5 * 8),
                new Data(manMonthName, 5 * 8 * 4),
                new Data(manYearName, 5 * 8 * 4 * 11),
            };
        internal const string manHourName = "ManHour";
        internal const string decaManHourName = "DecaManHour";
        internal const string hectoManHourName = "HectoManHour";
        internal const string kiloManHourName = "KiloManHour";
        internal const string megaManHourName = "MegaManHour";
        internal const string gigaManHourName = "GigaManHour";
        internal const string teraManHourName = "TeraManHour";
        internal const string manDayName = "ManDay";
        internal const string manWeekName = "ManWeek";
        internal const string manMonthName = "ManMonth";
        internal const string manYearName = "ManYear";

    }

}

