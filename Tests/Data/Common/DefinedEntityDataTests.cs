using Abc.Data.Common;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.Data.Common
{
    [TestClass]
    public class DefinedEntityDataTests : AbstractClassTests<DefinedEntityData, NamedEntityData>
    {
        private class testClass : DefinedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void DefinitionTest()
        {
            IsNullableProperty(() => obj.Definition, x => obj.Definition = x);
        }
    }
}
