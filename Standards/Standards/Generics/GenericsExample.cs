using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards.Generics
{
    public class GenericsExample<T>
    {
        public string DoSomething(T obj)
        {
            return string.Format("Doing something with {0}", obj.GetType().Name);
        }

    }
}
