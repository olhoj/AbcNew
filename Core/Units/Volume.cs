using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Volume {

        public static Data Measure = new Data("Volume", "V", null,
            "Volume is the quantity of three-dimensional space enclosed by " +
            "a closed surface, for example, the space that a substance " +
            "(solid, liquid, gas, or plasma) or shape occupies or contains. " +
            "Volume is often quantified numerically using the SI derived unit, " +
            "the cubic metre.",
            new TermData(Distance.Measure.Id, 3));
        public static List<Data> Units =>
            new List<Data> {
                new Data(cubicCentimetersName, new TermData(Distance.centimetersName, 3)),
                new Data(cubicDecametersName, new TermData(Distance.decametersName, 3)),
                new Data(cubicDecimetersName, new TermData(Distance.decimetersName, 3)),
                new Data(cubicFeetName, new TermData(Distance.feetName, 3)),
                new Data(cubicHectometersName, new TermData(Distance.hectometersName, 3)),
                new Data(cubicInchesName, new TermData(Distance.inchesName, 3)),
                new Data(cubicKilometersName, new TermData(Distance.kilometersName, 3)),
                new Data(cubicMetersName, new TermData(Distance.metersName, 3)),
                new Data(cubicMilesName, new TermData(Distance.milesName, 3)),
                new Data(cubicMillimetersName, new TermData(Distance.millimetersName, 3)),
                new Data(cubicYardsName, new TermData(Distance.yardsName, 3)),
                new Data(kiloLitersName, new TermData(Distance.metersName, 3)),
                new Data(litersName, new TermData(Distance.decimetersName, 3)),
                new Data(milliLitersName, new TermData(Distance.centimetersName, 3)),
                new Data(centiLitersName, new TermData(Distance.centimetersName, 2),
                    new TermData(Distance.decimetersName)),
                new Data(decaLitersName, new TermData(Distance.decimetersName, 2),
                    new TermData(Distance.metersName)),
                new Data(deciLitersName, new TermData(Distance.centimetersName, 2),
                    new TermData(Distance.metersName)),
                new Data(hectoLitersName, new TermData(Distance.metersName, 2),
                    new TermData(Distance.decimetersName))
            };

        internal const string cubicMillimetersName = "CubicMillimeters";
        internal const string cubicCentimetersName = "CubicCentimeters";
        internal const string cubicDecimetersName = "CubicDecimeters";
        internal const string cubicMetersName = "CubicMeters";
        internal const string cubicDecametersName = "CubicDecameters";
        internal const string cubicHectometersName = "CubicHectometers";
        internal const string cubicKilometersName = "CubicKilometers";
        internal const string cubicInchesName = "CubicInches";
        internal const string cubicFeetName = "CubicFeet";
        internal const string cubicYardsName = "CubicYards";
        internal const string cubicMilesName = "CubicMiles";
        internal const string milliLitersName = "MilliLiters";
        internal const string centiLitersName = "CentiLiters";
        internal const string deciLitersName = "DeciLiters";
        internal const string litersName = "Liters";
        internal const string decaLitersName = "DecaLiters";
        internal const string hectoLitersName = "HectoLiters";
        internal const string kiloLitersName = "KiloLiters";

    }

}
