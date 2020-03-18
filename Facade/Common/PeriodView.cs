using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abc.Domain.Quantity
{
    public abstract class PeriodView
    {
        [DataType(DataType.Date)]
        [DisplayName("Valid from")]
        public DateTime? ValidFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Valid from")]
        public DateTime? ValidTo { get; set; }
    }
}
