using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Facade.Quantity
{
    [TestClass]
    public class UnitFactorViewTests: SealedClassTests<UnitFactorView, PeriodView>
    {
        [TestMethod]
        public void UnitIdTest() => IsNullableProperty(() => obj.UnitId, x => obj.UnitId = x);
        [TestMethod]
        public void SystemOfUnitsIdTest() => IsNullableProperty(() => obj.SystemOfUnitsId, x => obj.SystemOfUnitsId = x);
        [TestMethod]
        public void FactorTest() => IsProperty(() => obj.Factor, x => obj.Factor = x);
    }
}
