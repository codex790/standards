using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Standards.Lambda;

namespace StandardsTest
{
    /// <summary>
    /// Summary description for LambdaExampleTest
    /// </summary>
    [TestClass]
    public class LambdaExampleTest
    {
        [TestMethod]
        public void TestLambdaExample()
        {
            var lambdaExample = new LambdaExample();

            var doub = lambdaExample.RunDouble(5);
            Assert.AreEqual(doub, 10);

            var square = lambdaExample.RunSquare(5);
            Assert.AreEqual(square, 25);

        }
    }
}
