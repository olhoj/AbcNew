using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitfactorDataTests : SealedClassTests<UnitFactorData, PeriodData>
    {
        [TestMethod]
        public void FactorTest()
        {
            IsProperty(() => obj.Factor, x => obj.Factor = x);
        }

        [TestMethod]
        public void SystemOfUnitsIdTest()
        {
            IsNullableProperty(() => obj.SystemOfUnitsId, x => obj.SystemOfUnitsId = x);
        }

        [TestMethod]
        public void UnitIdTest()
        {
            IsNullableProperty(() => obj.UnitId, x => obj.UnitId = x);
        }
    }
}
