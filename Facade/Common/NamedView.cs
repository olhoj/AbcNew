using System.ComponentModel.DataAnnotations;

namespace Abc.Domain.Quantity
{
    public abstract class NamedView : UniqueEntityView
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        
    }
}
