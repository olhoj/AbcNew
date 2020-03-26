using Abc.Data.Common;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class UniqueEntityDataTests : AbstractClassTests<UniqueEntityData, PeriodData>
    {
        private class testClass : UniqueEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void IdTest()
        {
            IsNullableProperty(() => obj.Id, x => obj.Id = x);
        }
    }
}
