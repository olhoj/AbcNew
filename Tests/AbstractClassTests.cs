using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests
{
    public abstract class AbstractClassTests<TClass, TBaseClass> : BaseClassTests<TClass, TBaseClass>
    {

        [TestMethod]
        public void IsAbstractTest()
        {
            Assert.IsTrue(type.IsAbstract);
        }
    }
}
