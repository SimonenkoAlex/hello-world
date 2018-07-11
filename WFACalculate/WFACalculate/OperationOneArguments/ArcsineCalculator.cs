using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACalculate.OperationOneArguments
{
    public class ArcsineCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new Exception("Не существует");
            }
            return Math.Asin(firstArgument);
        }
    }
}
