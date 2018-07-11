﻿using System;

namespace WFACalculate.OperationOneArguments
{
    public class LogarithmCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new Exception("Не существует");
            }
            return Math.Log(firstArgument);
        }
    }
}
