using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public sealed class UnitFactorView: PeriodView
    {
        [Required]
        [DisplayName("Unit")]
        public string UnitId { get; set; }
        [Required]
        [DisplayName("System of Units")]
        public string SystemOfUnitsId { get; set; }
        public double Factor { get; set; }


    }
}
