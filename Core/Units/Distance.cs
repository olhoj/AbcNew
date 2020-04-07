using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Distance {

        public static Data Measure = new Data
        (
            "Distance", "l", "Distance", "The measurement or extent of something from end to end."
        );

        public static List<Data> Units =>
            new List<Data> {
                new Data(angstromsName, Factors.Angstrom),
                new Data(astronomicalUnitsName, astronomicalUnitsFactor),
                new Data(centimetersName, "cm", Factors.Centi),
                new Data(chainsName, chainsFactor),
                new Data(cubitsName, cubitsFactor),
                new Data(decametersName, Factors.Deca),
                new Data(decimetersName, "dm", Factors.Deci),
                new Data(fathomsName, fathomsFactor),
                new Data(feetName, feetFactor),
                new Data(furlongsName, furlongsFactor),
                new Data(gigametersName, Factors.Giga),
                new Data(handsName, handsFactor),
                new Data(hectometersName, Factors.Hecto),
                new Data(inchesName, inchesFactor),
                new Data(kilometersName, "km", Factors.Kilo),
                new Data(lightSecondsName, lightSecondsFactor),
                new Data(lightYearsName, lightYearsFactor),
                new Data(linksName, linksFactor),
                new Data(megametersName, Factors.Mega),
                new Data(metersName, "m", 1),
                new Data(micromicronsName, Factors.Micromicro),
                new Data(micronsName, Factors.Micro),
                new Data(milesName, milesFactor),
                new Data(millimetersName, "mm", Factors.Milli),
                new Data(millimicronsName, Factors.Millimicro),
                new Data(nanometersName, Factors.Nano),
                new Data(nauticalMilesName, nauticalMilesFactor),
                new Data(pacesName, pacesFactor),
                new Data(parsecsName, parsecsFactor),
                new Data(picasName, picasFactor),
                new Data(pointsName, pointsFactor),
                new Data(rodsName, rodsFactor),
                new Data(yardsName, yardsFactor)
            };
        internal  const string astronomicalUnitsName = "AstronomicalUnits";
        internal  const string angstromsName = "Angstroms";
        internal  const string centimetersName = "Centimeters";
        internal  const string chainsName = "Chains";
        internal  const string cubitsName = "Cubits";
        internal  const string decametersName = "Decameters";
        internal  const string decimetersName = "Decimeters";
        internal  const string feetName = "Feet";
        internal  const string fathomsName = "Fathoms";
        internal  const string furlongsName = "Furlongs";
        internal  const string gigametersName = "Gigameters";
        internal  const string handsName = "Hands";
        internal  const string hectometersName = "Hectometers";
        internal  const string inchesName = "Inches";
        internal  const string kilometersName = "Kilometers";
        internal  const string lightYearsName = "LightYears";
        internal  const string lightSecondsName = "LightSeconds";
        internal  const string linksName = "Links";
        internal  const string metersName = "Meters";
        internal  const string micromicronsName = "Micromicrons";
        internal  const string megametersName = "Megameters";
        internal  const string micronsName = "Microns";
        internal  const string milesName = "Miles";
        internal  const string millimetersName = "Millimeters";
        internal  const string millimicronsName = "Millimicrons";
        internal  const string nanometersName = "Nanometers";
        internal  const string nauticalMilesName = "NauticalMiles";
        internal  const string pacesName = "Paces";
        internal  const string parsecsName = "Parsecs";
        internal  const string picasName = "Picas";
        internal  const string pointsName = "Points";
        internal  const string rodsName = "Rods";
        internal  const string yardsName = "Yards";

        internal  const double astronomicalUnitsFactor = 1.49598E11;
        internal  const double chainsFactor = rodsFactor * 4.0;
        internal  const double cubitsFactor = 0.4572;
        internal  const double fathomsFactor = feetFactor * 6.0;
        internal  const double feetFactor = inchesFactor * 12.0;
        internal  const double furlongsFactor = yardsFactor * 220.0;
        internal  const double handsFactor = inchesFactor * 4.0;
        internal  const double inchesFactor = 0.0254;
        internal  const double lightSecondsFactor = 2.99792458E8;
        internal  const double lightYearsFactor = lightSecondsFactor * 31556925.9747;
        internal  const double linksFactor = chainsFactor / 100.0;
        internal  const double milesFactor = feetFactor * 5280;
        internal  const double nauticalMilesFactor = 1852.0;
        internal  const double pacesFactor = inchesFactor * 30.0;
        internal  const double parsecsFactor = astronomicalUnitsFactor * 206264.806247096;
        internal  const double picasFactor = pointsFactor * 12.0;
        internal  const double rodsFactor = feetFactor * 16.5;
        internal  const double pointsFactor = inchesFactor * 0.013837;
        internal  const double yardsFactor = feetFactor * 3.0;

    }

}
