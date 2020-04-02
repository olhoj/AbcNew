using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Quantity
{
    public sealed class MeasureTermView: CommonTermView
    {
        [Required]
        [DisplayName("Measure")]
        public string MasterId { get; set; }
    }
}
