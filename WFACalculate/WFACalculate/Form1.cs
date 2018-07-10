using System;
using System.Globalization;
using System.Windows.Forms;
using WFACalculate.OperationOneArguments;
using WFACalculate.OperationTwoArguments;

namespace WFACalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstArgument, secondArgument);
                textBox3.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception exception)
            {
                textBox3.Text = exception.Message;
            }
        }

        private void btn_ClickOneArgument(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstArgument);
                textBox3.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch ( Exception exception)
            {
                textBox3.Text = exception.Message;
            }
        }
    }
}
