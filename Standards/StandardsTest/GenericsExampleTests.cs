using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Standards;
using Standards.Generics;

namespace StandardsTest
{
    [TestClass]
    public class GenericsExampleTests
    {
        [TestMethod]
        public void TestGenericsExample()
        {
            var example = new GenericsExample<int>();
            var intVar = 1;
            var result = example.DoSomething(intVar);
            Assert.IsTrue(result == string.Format("Doing something with {0}", intVar.GetType().Name));

            var example2 = new GenericsExample<TestClass>();
            var testClass = new TestClass() { MyProperty = 123 };
            var result2 = example2.DoSomething(testClass);
            Assert.IsTrue(result2 == string.Format("Doing something with {0}", testClass.GetType().Name));
        }
    }
}
