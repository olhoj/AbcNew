using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abc.Domain.Quantity;

namespace Abc.Facade.Quantity
{
    public abstract class CommonTermView: PeriodView
    {
        [Required]
        [DisplayName("Term")]
        public string TermId { get; set; }
        public int Power { get; set; }
    }
}