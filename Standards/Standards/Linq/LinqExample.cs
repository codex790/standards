using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards.Linq
{
    public class LinqExample
    {
        public List<Developer> GetDevelopersWithSqlSkills(List<Developer> allDevelopers)
        {
            var sqlDevs = allDevelopers.Where(p => p.Skills.Any(x => x.ToLower() == "sql")).ToList();
            return sqlDevs;
        }
    }
}
