using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Persentage {

        public static Data Measure = new Data(percentageName);

        public static List<Data> Units =>
            new List<Data> {
                new Data(percentageName, "%", 1)
            };
        internal const string percentageName = "Percentage";

    }

}
