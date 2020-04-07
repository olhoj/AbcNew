using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Mass {

        public static Data Measure = new Data(
            measureName,
            "m",
            measureName,
            "The quantity of matter which a body contains, as measured by " +
            "its acceleration under a given force or by the force exerted on " +
            "it by a gravitational field"
        );

        public static List<Data> Units =>
            new List<Data> {
                new Data(centigramsName, centigramsFactor),
                new Data(decagramsName, Factors.Centi),
                new Data(decigramsName, decigramsFactor),
                new Data(dramsName, dramsFactor),
                new Data(grainsName, grainsFactor),
                new Data(gramsName, "g", Factors.Milli),
                new Data(hectogramsName, Factors.Deci),
                new Data(kilogramsName, "kg", 1),
                new Data(longTonsName, longTonsFactor),
                new Data(metricTonsName, "T", Factors.Kilo),
                new Data(microgramsName, Factors.Nano),
                new Data(milligramsName, Factors.Micro),
                new Data(nanogramsName, Factors.Pico),
                new Data(ouncesName, ouncesFactor),
                new Data(poundsName, poundFactor),
                new Data(stonesName, stonesFactor),
                new Data(tonsName, tonsFactor)
            };

        internal const string measureName = "Mass";
        internal const string centigramsName = "Centigrams";
        internal const string decagramsName = "Decagrams";
        internal const string decigramsName = "Decigrams";
        internal const string dramsName = "Drams";
        internal const string grainsName = "Grains";
        internal const string gramsName = "Grams";
        internal const string hectogramsName = "Hectograms";
        internal const string kilogramsName = "Kilograms";
        internal const string longTonsName = "LongTons";
        internal const string metricTonsName = "MetricTons";
        internal const string microgramsName = "Micrograms";
        internal const string milligramsName = "Milligrams";
        internal const string nanogramsName = "Nanograms";
        internal const string ouncesName = "Ounces";
        internal const string poundsName = "Pounds";
        internal const string stonesName = "Stones";
        internal const string tonsName = "Tons";

        internal static double centigramsFactor => Factors.Milli * Factors.Centi;
        internal static double decigramsFactor => Factors.Milli * Factors.Deci;
        internal const double dramsFactor = poundFactor / 256;
        internal const double grainsFactor = poundFactor / 7000;
        internal const double longTonsFactor = poundFactor * 2240;
        internal const double ouncesFactor = poundFactor / 16;
        internal const double poundFactor = 0.45359237;
        internal const double stonesFactor = poundFactor * 14;
        internal const double tonsFactor = poundFactor * 2000;

    }

}
