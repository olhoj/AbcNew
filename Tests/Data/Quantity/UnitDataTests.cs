using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests: SealedClassTests<UnitData,DefinedEntityData>
    {
        [TestMethod]
        public void MeasureIDTest()
        {
            IsNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
