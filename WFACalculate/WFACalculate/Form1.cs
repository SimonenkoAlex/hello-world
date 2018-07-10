using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument, secondArgument);
            textBox3.Text = result.ToString();
        }

        private void btn_ClickOneArgument(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firstArgument);
            textBox3.Text = result.ToString();
        }
    }
}
