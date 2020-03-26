using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests
{
    public abstract class ClassTests<TClass, TBaseClass> : BaseClassTests<TClass, TBaseClass> where TClass : new()
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            obj = new TClass();
            type = obj.GetType();
        }

        [TestMethod]
        public void CanCreateTest()
        {
            Assert.IsNotNull(obj);
        }
    }
}
