using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards.Lambda
{
    public class LambdaExample
    {
        private delegate int Calculate(int val);

        public int RunSquare(int val)
        {
            Calculate Square = x => x * x;
            return Square(val);            
        }

        public int RunDouble(int val)
        {
            Calculate Double = x => x * 2;
            return Double(val);
        }
        

    }
}
