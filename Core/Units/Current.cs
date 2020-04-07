
using System.Collections.Generic;

namespace Abc.Core.Units {

    public static class Current {

        public static Data Measure = new Data( 
            "Current",
            "I",
            "Electric Current",
            "An electric current is the rate of flow of electric charge " +
                         "past a point or region. An electric current is said to exist " +
                         "when there is a net flow of electric charge through a region." +
                         "In electric circuits this charge is often carried by electrons " +
                         "moving through a wire. It can also be carried by ions in an " +
                         "electrolyte, or by both ions and electrons such as in an " +
                         "ionized gas (plasma)"
        );
        public static List<Data> Units =>
            new List<Data> {
            };

    }

}
