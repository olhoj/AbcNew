using System;

namespace Abc.Data.Common
{
    public abstract class PeriodData
    {

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
