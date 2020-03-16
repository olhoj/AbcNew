using Abc.Data.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Data.Quantity
{
    public sealed class UnitFactorData:PeriodData
    {
        public string UnitId { get; set; }
        public string SystemOfUnitsId { get; set; }

        public double Factor { get; set; }

    }
}
