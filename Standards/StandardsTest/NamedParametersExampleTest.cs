using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Standards.NamedParameters;

namespace StandardsTest
{
    [TestClass]
    public class NamedParametersExampleTest
    {
        [TestMethod]
        public void TestNamedParametersExample()
        {
            var namedParamsExample = new NamedParametersExample();
            var standardParamsResult = namedParamsExample.GetPowerWithStandardParameters(4, 3);
            Assert.AreEqual(standardParamsResult, 64);

            var namedParamsResult = namedParamsExample.GetPowerWithNamedParameters(4, 3);
            Assert.AreEqual(namedParamsResult, 64);
        }

    }
}
