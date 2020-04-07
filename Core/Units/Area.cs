using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Area {
        public static Data Measure = new Data
        ("Area", "A", null, "Area is the quantity that expresses the extent of a " +
                         "two-dimensional figure or shape or planar lamina, in the plane.",
            new TermData(Distance.Measure.Id, 2)
        );

        public static List<Data> Units =>
            new List<Data> {
                new Data(acresName,new TermData(Distance.furlongsName),
                    new TermData(Distance.chainsName)),
                new Data(aresName,new TermData(Distance.decametersName, 2)),
                new Data(centiaresName,new TermData(Distance.metersName, 2)),
                new Data(hectaresName,new TermData(Distance.hectometersName, 2)),
                new Data(squareCentimetersName,new TermData(Distance.centimetersName, 2)),
                new Data(squareDecametersName,new TermData(Distance.decametersName, 2)),
                new Data(squareDecimetersName,new TermData(Distance.decimetersName, 2)),
                new Data(squareFeetName,new TermData(Distance.feetName, 2)),
                new Data(squareHectometersName,new TermData(Distance.hectometersName, 2)),
                new Data(squareInchesName,new TermData(Distance.inchesName, 2)),
                new Data(squareKilometersName,new TermData(Distance.kilometersName, 2)),
                new Data(squareMetersName, new TermData(Distance.metersName, 2)),
                new Data(squareMilesName,new TermData(Distance.milesName, 2)),
                new Data(squareMillimetersName,new TermData(Distance.millimetersName, 2)),
                new Data(squareRodsName,new TermData(Distance.rodsName, 2)),
                new Data(squareYardsName, new TermData(Distance.yardsName, 2))
            };


        internal const string acresName = "Acres";
        internal const string aresName = "Ares";
        internal const string centiaresName = "Centiares";
        internal const string hectaresName = "Hectares";
        internal const string squareCentimetersName = "SquareCentimeters";
        internal const string squareDecimetersName = "SquareDecimeters";
        internal const string squareDecametersName = "SquareDecameters";
        internal const string squareFeetName = "SquareFeet";
        internal const string squareHectometersName = "SquareHectometers";
        internal const string squareInchesName = "SquareInches";
        internal const string squareKilometersName = "SquareKilometers";
        internal const string squareMetersName = "SquareMeters";
        internal const string squareMilesName = "SquareMiles";
        internal const string squareMillimetersName = "SquareMillimeters";
        internal const string squareRodsName = "SquareRods";
        internal const string squareYardsName = "SquareYards";

    }

}
