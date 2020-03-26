using Abc.Aids;
using Abc.Data.Common;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common
{
    public class EntityTests : AbstractClassTests<Entity<MeasureData>, object>
    {
        private class testClass : Entity<MeasureData> 
        { 
        public testClass(MeasureData d = null) : base(d) { }
        }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod] public void DataTest()
        {
            var d = GetRandom.Object<MeasureData>();
            Assert.AreNotSame(d, obj.Data);
            obj = new testClass(d);
            Assert.AreSame(d, obj.Data);
        }

        [TestMethod] public void DataIsNullTest()
        {
            var d = GetRandom.Object<MeasureData>();
            Assert.IsNull(obj.Data);
            obj.Data = d;
            Assert.AreSame(d, obj.Data);
        }
    }
}
