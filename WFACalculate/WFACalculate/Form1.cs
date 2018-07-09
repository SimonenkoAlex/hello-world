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
            double result;
            switch (((Button)sender).Name)
            {
                case "btnAdd": result = firstArgument + secondArgument; break;
                case "btnMinus": result = firstArgument - secondArgument; break;
                case "btnMultiplication": result = firstArgument * secondArgument; break;
                case "btnDivision": result = firstArgument / secondArgument; break;
                default: throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }
    }
}
