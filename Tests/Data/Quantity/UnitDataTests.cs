using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests: SealedClassTest<UnitData,DefinedEntityData>
    {
        [TestMethod]
        public void MeasureIDTest()
        {
            IsNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
