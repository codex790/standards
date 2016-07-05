using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Standards.Sort;

namespace StandardsTest
{
    /// <summary>
    /// Summary description for SortExampleTest
    /// </summary>
    [TestClass]
    public class SortExampleTest
    {        
        [TestMethod]
        public void TestInsertSort()
        {
            var sortExample = new SortExample();
            //var array = sortExample.GetRandomArray(1, 20, 8);
            var array = new int[] { 12, 2, 4, 53, 2, 1 };
            var sortedArray = sortExample.InsertionSort(array);

            Assert.AreEqual(sortedArray[0], 1);
            Assert.AreEqual(sortedArray[1], 2);
            Assert.AreEqual(sortedArray[2], 2);
            Assert.AreEqual(sortedArray[3], 4);
            Assert.AreEqual(sortedArray[4], 12);
            Assert.AreEqual(sortedArray[5], 53);
        }
    }
}
