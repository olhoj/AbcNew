using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Domain.Quantity
{
    public class MeasureView
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
        public string Definition { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Valid from")]
        public DateTime? ValidFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Valid from")]
        public DateTime? ValidTo { get; set; }


    }
}
