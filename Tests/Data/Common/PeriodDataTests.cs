using Abc.Data.Common;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Data.Common
{
    [TestClass]
    public class PeriodDataTests : AbstractClassTests<PeriodData, object>
    {
        private class testClass : PeriodData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod] public void ValidFromTest()
        {
           IsNullableProperty(() => obj.ValidFrom, x => obj.ValidFrom = x);
        }

        [TestMethod]
        public void ValidToTest()
        {
           IsNullableProperty(() => obj.ValidTo, x => obj.ValidTo = x);

        }
    }
}
