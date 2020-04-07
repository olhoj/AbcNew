using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Luminos {

        public static Data Measure = new Data
        ("Luminous", "Iv", "Luminous Intensity", "In photometry, luminous intensity is a measure of the " +
                                                 "wavelength-weighted power emitted by a light source in a " +
                                                 "particular direction per unit solid angle, based on the " +
                                                 "luminosity function, a standardized model of the sensitivity " +
                                                 "of the human eye");
        public static List<Data> Units =>
            new List<Data> {
                new Data(
                    "Candela", "cd", "Candela",
                    "The candela is the base unit of luminous intensity " +
                    "in the International System of Units (SI); that is, luminous power " +
                    "per unit solid angle emitted by a point light source in a particular direction. ",
                    1),
                new Data("Candlepower", "cp", "Candlepower",
                    "Candlepower (abbreviated as cp or CP) is an obsolete unit of " +
                    "measurement for luminous intensity. It expresses levels of light intensity " +
                    "relative to the light emitted by a candle of specific size and constituents. " +
                    "The historical candlepower is equal to 0.981 candelas. In modern usage, candlepower " +
                    "is sometimes used as a synonym for candela.", 0.981),
                new Data("Hefnerkerze", "HK", "Hefnerkerze",
                    "The Hefner lamp, or in German Hefnerkerze, is a flame lamp used in " +
                    "photometry that burns amyl acetate.The lamp was invented by Friedrich von Hefner-Alteneck " +
                    "in 1884 and he proposed its use as a standard flame for photometric purposes with " +
                    "a luminous intensity unit of the Hefnerkerze (HK). The lamp was specified as " +
                    "having a 40 mm flame height and an 8 mm diameter wick.", 0.920)
            };

    }

}
