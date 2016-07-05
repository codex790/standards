using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Standards;
using Standards.Linq;
using System.Collections.Generic;

namespace StandardsTest
{
    [TestClass]
    public class LinqExampleTest
    {

        [TestMethod]
        public void TestSqlDevelopers()
        {
            var developers = new List<Developer> {
                new Developer() { Name = "Teresa", Skills = new List<string> { "sql", "c#", "javascript", "java" } },
                new Developer() { Name = "James", Skills = new List<string> { "c#", "oracle", "vb" } },
                new Developer() { Name = "Sally", Skills = new List<string> { "php", "sql" } }
            };

            var results = new LinqExample().GetDevelopersWithSqlSkills(developers);

            Assert.AreEqual(results.Count, 2);

        }

    }
}
