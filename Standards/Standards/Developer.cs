using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards
{
    public class Developer
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }
        public bool Enabled { get; set; }

        public Developer() { }

        public Developer(string name, bool enabled = true)
        {
            Name = name;
            Enabled = enabled;
        }
    }
}
