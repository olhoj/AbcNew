
using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Temperature {

        public static Data Measure = new Data
        (
            measureName,
            "T",
            "Thermodynamic Temperature",
            "Thermodynamic temperature is the absolute measure of temperature " +
            "and is one of the principal parameters of thermodynamics."
        );
        public static List<Data> Units =>
            new List<Data> {
                new Data(kelvinName, "°K"),
                new Data(celsiusName, "°C", celsiusFactor),
                new Data(fahrenheitName, "°F", fahrenheitFactor),
                new Data(rankineName, "°R", rankineFactor)
            };


        internal const string measureName = "Temperature";

        internal const string celsiusName = "Celsius";
        internal const string fahrenheitName = "Fahrenheit";
        internal const string kelvinName = "Kelvin";
        internal const string rankineName = "Rankine";

        internal const string celsiusToKelvinRuleId = "Celsius to Kelvin";
        internal const string fahrenheitToKelvinRuleId = "Fahrenheit to Kelvin";
        internal const string rankineToKelvinRuleId = "Rankine to Kelvin";
        internal const string kelvinToCelsiusRuleId = "Kelvin to Celsius";
        internal const string kelvinToFahrenheitRuleId = "Kelvin to Fahrenheit";
        internal const string kelvinToRankineRuleId = "Kelvin to Rankine";

        internal const double celsiusFactor = 273.15;
        internal const double fahrenheitFactor = 459.67;
        internal const double rankineFactor = 1.8000;

    }

}
