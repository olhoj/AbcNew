using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Time {

        public static Data Measure =
            new Data
            (
                "Time",
                "t",
                "Time",
                "In physical science, time is defined as a measurement, " +
                "or as what the clock face reads."
            );

        public static List<Data> Units =>
            new List<Data> {
                new Data(centuriesName, centuriesFactor),
                new Data(decadesName, decadesFactor),
                new Data(daysName, daysFactor),
                new Data(fortnightsName, fortnightsFactor),
                new Data(hoursName, "h", hoursFactor),
                new Data(microsecondsName, Factors.Micro),
                new Data(millenniumName, millenniumFactor),
                new Data(millisecondsName, Factors.Milli),
                new Data(minutesName, "min", minutesFactor),
                new Data(monthsName, monthsFactor),
                new Data(nanosecondsName, Factors.Nano),
                new Data(secondsName, "sec", 1),
                new Data(weeksName, weeksFactor),
                new Data(yearsName, yearsFactor)

            };

        internal const string nanosecondsName = "Nanoseconds";
        internal const string microsecondsName = "Microseconds";
        internal const string millisecondsName = "Milliseconds";
        internal const string secondsName = "Seconds";
        internal const string minutesName = "Minutes";
        internal const string hoursName = "Hours";
        internal const string daysName = "Days";
        internal const string weeksName = "Weeks";
        internal const string fortnightsName = "Fortnights";
        internal const string monthsName = "Months";
        internal const string yearsName = "Years";
        internal const string decadesName = "Decades";
        internal const string centuriesName = "Centuries";
        internal const string millenniumName = "Millennium";

        internal const double hoursPerDay = 24.0;
        internal const double minutesFactor = 60.0;
        internal const double hoursFactor = minutesFactor * minutesFactor;
        internal const double daysFactor = hoursPerDay * hoursFactor;
        internal const double daysPerWeek = 7.0;
        internal const double weeksFactor = daysPerWeek * daysFactor;
        internal const double weeksPerFortnight = 2.0;
        internal const double approxDaysPerMonth = 30.4375;
        internal const double monthsFactor = approxDaysPerMonth * daysFactor;
        internal const double approxDaysPerYear = 365.25;
        internal const double yearsFactor = approxDaysPerYear * daysFactor;
        internal const double yearsPerDecade = 10.0;
        internal const double yearsPerCentury = 10.0 * yearsPerDecade;
        internal const double yearsPerMillennium = 10.0 * yearsPerCentury;
        internal const double fortnightsFactor = weeksPerFortnight * weeksFactor;
        internal const double decadesFactor = yearsPerDecade * yearsFactor;
        internal const double centuriesFactor = yearsPerCentury * yearsFactor;
        internal const double millenniumFactor = yearsPerMillennium * yearsFactor;

    }

}
