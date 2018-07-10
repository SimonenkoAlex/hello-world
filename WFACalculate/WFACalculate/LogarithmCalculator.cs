using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACalculate
{
    public class LogarithmCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}
