using System.ComponentModel.DataAnnotations;

namespace Abc.Domain.Quantity
{
    public abstract class UniqueEntityView : PeriodView
    {
        [Required]
        public string Id { get; set; }
    }
}
