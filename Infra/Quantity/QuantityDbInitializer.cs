using Abc.Data.Quantity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abc.Infra.Quantity
{
    public static class QuantityDbInitializer
    {
        internal static List<MeasureData> measures => new List<MeasureData> {
            new MeasureData {Id ="Time", Name = "Time", Code = "t",
                Definition = "In physical science, time is defined as a measurement, "+
                             "or as what the clock face reads."},
            new MeasureData {Id ="Length", Name = "Length", Code = "l",
                Definition = "The measurement or extent of something from end to end."},
            new MeasureData {Id ="Mass", Name = "Mass", Code = "m",
                Definition = "The quantity of matter which a body contains, as measured by "+
                             "its acceleration under a given force or by the force exerted on "+
                             "it by a gravitational field"},
            new MeasureData {Id ="Current", Name = "Electric Current", Code = "I",
                Definition = "An electric current is the rate of flow of electric charge "+
                             "past a point or region. An electric current is said to exist "+
                             "when there is a net flow of electric charge through a region."+
                             "In electric circuits this charge is often carried by electrons "+
                             "moving through a wire. It can also be carried by ions in an "+
                             "electrolyte, or by both ions and electrons such as in an "+
                             "ionized gas (plasma)"},
            new MeasureData {Id ="Temperature", Name = "Thermodynamic Temperature", Code = "T",
                Definition = "Thermodynamic temperature is the absolute measure of temperature "+
                             "and is one of the principal parameters of thermodynamics."},
            new MeasureData {Id ="Substance", Name = "Amount of Substance", Code = "n",
                Definition = "In chemistry, the amount of substance in a given "+
                             "sample of matter is the number of discrete atomic-scale "+
                             "particles in it; where the particles may be molecules, "+
                             "atoms, ions, electrons, or other, depending on the context. "+
                             "It is sometimes referred to as the chemical amount."},
            new MeasureData {Id ="Luminous", Name = "Luminous Intensity", Code = "Iv",
                Definition = "In photometry, luminous intensity is a measure of the "+
                             "wavelength-weighted power emitted by a light source in a "+
                             "particular direction per unit solid angle, based on the "+
                             "luminosity function, a standardized model of the sensitivity "+
                             "of the human eye"} 
        };
        public static void Initialize(QuantityDbContext db)
        {
            if (db.Measures.Any()) return;
            db.Measures.AddRange(measures);
            db.SaveChanges();
        }
    }
}
