using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Facade.Quantity
{
    public sealed class UnitTermView:CommonTermView
    {
        [Required]
        [DisplayName("Unit")]
        public string MasterId { get; set; }
    }
}
