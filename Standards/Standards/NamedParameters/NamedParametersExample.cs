using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standards.NamedParameters
{
    public class NamedParametersExample
    {
        private double Power(double baseNumber, double powerNumber)
        {
            return Math.Pow(baseNumber, powerNumber);
        }

        public double GetPowerWithStandardParameters(double baseNumber, double powerNumber)
        {
            return Power(baseNumber, powerNumber);
        }

        public double GetPowerWithNamedParameters(double baseNumber, double powerNumber)
        {
            return Power(powerNumber: powerNumber, baseNumber: baseNumber);
        }
    }
}
