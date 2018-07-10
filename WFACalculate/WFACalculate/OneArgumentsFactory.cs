using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFACalculate
{
    public static class OneArgumentsFactory
    {
        public static IOneArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "btnSin": return new SinusCalculator();
                case "btnCos": return new CosineCalculator();
                case "btnLog": return new LogarithmCalculator();
                case "btnPow": return new PowerCalculator();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
