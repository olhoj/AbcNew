using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class SystemOfUnits {

        public static string SiSystemId = "SI";
        public static string CgsSystemId = "CGS";

        public static List<Data> Units =>
            new List<Data> {
                new Data(SiSystemId, SiSystemId, "International System of Units",
                    "The International System of Units (SI, abbreviated from the " +
                    "French Système international (d'unités)) is the modern form " +
                    "of the metric system and is the most widely used system of measurement. " +
                    "It comprises a coherent system of units of measurement built on seven " +
                    "base units, which are the second, metre, kilogram, ampere, kelvin, mole, " +
                    "candela, and a set of twenty prefixes to the unit names and unit symbols " +
                    "that may be used when specifying multiples and fractions of the units."
                ),
                new Data(
                    CgsSystemId, CgsSystemId,
                    "Centimetre–Gram–Second System of Units",
                    "The centimetre–gram–second system of units (abbreviated CGS or cgs) " +
                    "is a variant of the metric system based on the centimetre as the unit " +
                    "of length, the gram as the unit of mass, and the second as the unit of " +
                    "time. All CGS mechanical units are unambiguously derived from these three " +
                    "base units, but there are several different ways of extending the " +
                    "CGS system to cover electromagnetism."
                )
            };

    }

}
