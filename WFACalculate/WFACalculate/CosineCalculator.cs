using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACalculate
{
    public class CosineCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
