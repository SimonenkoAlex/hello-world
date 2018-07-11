﻿using System;

namespace WFACalculate.OperationOneArguments
{
    public class SinusCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
