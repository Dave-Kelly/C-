using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string input = string.Empty;        //Storing user input
        double operand1 = 0;                //Storing operand 1
        double operand2 = 0;                //Storing operand 2
        char operation;                     //Storing operation
        double result = 0.0;                //Storing result

        public Calculator()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            this.screen.Text = input;
            this.operand1 = 0;
            this.operand2 = 0;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "0";
            this.screen.Text += input;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "1";
            this.screen.Text = input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "2";
            this.screen.Text = input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "3";
            this.screen.Text = input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "4";
            this.screen.Text = input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "5";
            this.screen.Text = input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "6";
            this.screen.Text = input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "7";
            this.screen.Text = input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "8";
            this.screen.Text = input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.screen.Text = "";
            input += "9";
            this.screen.Text = input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (this.screen.Text != "")
            {
                input += ".";
            }
            this.screen.Text += input;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out operand1);
            operation = '/';
            input = string.Empty;
            this.screen.Text = input;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out operand1);
            operation = '-';
            input = string.Empty;
            this.screen.Text = input;
        }

        private void add_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out operand1);
            operation = '+';
            input = string.Empty;
            this.screen.Text = input;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out operand1);
            operation = '*';
            input = string.Empty;
            this.screen.Text = input;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (input != "")
            {
                double.TryParse(input, out operand2);
                if (operation == '+')
                {
                    result = operand1 + operand2;
                    this.screen.Text = result.ToString();
                }
                else if (operation == '-')
                {
                    result = operand1 - operand2;
                    this.screen.Text = result.ToString();
                }
                else if (operation == '*')
                {
                    result = operand1 * operand2;
                    this.screen.Text = result.ToString();
                }
                else if (operation == '/')
                {
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                        this.screen.Text = result.ToString();
                    }
                    else
                    {
                        this.screen.Text = "!Division/Zero";
                    }

                }
                input = string.Empty;
            }
        }
    }
}
