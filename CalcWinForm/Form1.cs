using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(firstValue.Text);
            double y = Convert.ToDouble(secondValue.Text); ;
            char op = Convert.ToChar(operValue.Text);
            resultValue.Text = Calculate(x, y, op).ToString();
        }

        private double Calculate(double x, double y, char op)
        {
            double result = 0;

            if (op == '+')
                result = x + y;
            else if (op == '-')
                result = x - y;
            else if (op == '*')
                result = x * y;
            else if (op == '/')
                result = x / y;


            return result;
        }
    }
}
