namespace WFACalculate.OperationOneArguments
{
    public class NegativeCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * (-1);
        }
    }
}
