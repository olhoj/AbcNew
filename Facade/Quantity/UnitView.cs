using Abc.Domain.Quantity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Quantity
{
    public class UnitView : DefinedView
    {
        [Required]
        [DisplayName("Measure")]

        public string MeasureId { get; set; }
    }
}
