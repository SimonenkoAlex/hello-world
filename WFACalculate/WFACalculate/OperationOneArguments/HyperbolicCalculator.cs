namespace WFACalculate.OperationOneArguments
{
    public class HyperbolicCalculator: IOneArgumentsCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 1 / firstArgument;
        }
    }
}
