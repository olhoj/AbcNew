using Abc.Data.Quantity;
using Abc.Domain.Common;
using Abc.Domain.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Tests.Domain.Quantity
{
    [TestClass]
    public class MeasureTests : SealedClassTests<Measure, Entity<MeasureData>> { }
}
