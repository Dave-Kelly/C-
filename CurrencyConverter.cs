using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {

        double num1 = 0;                //User input - amount to be converted
        double num2 = 0;                //Output result - converted amount
        string numberString = "";       //'inputCurrency' textbox input value  

        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "1";
            this.inputCurrency.Text = numberString;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "2";
            this.inputCurrency.Text = numberString;

        }

        private void three_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "3";
            this.inputCurrency.Text = numberString;

        }

        private void four_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "4";
            this.inputCurrency.Text = numberString;

        }

        private void five_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "5";
            this.inputCurrency.Text = numberString;

        }

        private void six_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "6";
            this.inputCurrency.Text = numberString;

        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "7";
            this.inputCurrency.Text = numberString;

        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "8";
            this.inputCurrency.Text = numberString;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "9";
            this.inputCurrency.Text = numberString;

        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString += "0";
            this.inputCurrency.Text = numberString;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            numberString = "";
            this.inputCurrency.Text = numberString;
            this.outputCurrency.Text = numberString;
            num1 = 0;
            num2 = 0;

        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.inputCurrency.Text = "";
            if (numberString != "")
            {
                numberString += ".";
            }
            this.inputCurrency.Text = numberString;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (numberString != "") //if the input is not empty -> continue
            {
                double.TryParse(numberString, out num1); //parse the double value from the input string

                //For Eruo
                if((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 0))
                {
                    num2 = num1 * 1;
                }
                else if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 1))
                {
                    num2 = num1 * 0.87;
                }
                else if ((comboBox1.SelectedIndex == 0) && (comboBox2.SelectedIndex == 2))
                {
                    num2 = num1 * 1.12;
                }
                //For Pound
                else if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 0))
                {
                    num2 = num1 * 1.17;
                }
                else if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 1))
                {
                    num2 = num1 * 1;
                }
                else if ((comboBox1.SelectedIndex == 1) && (comboBox2.SelectedIndex == 2))
                {
                    num2 = num1 * 1.30;
                }
                //For US Dollar
                else if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 0))
                {
                    num2 = num1 * 0.89;
                }
                else if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 1))
                {
                    num2 = num1 * 0.77;
                }
                else if ((comboBox1.SelectedIndex == 2) && (comboBox2.SelectedIndex == 2))
                {
                    num2 = num1 * 1;
                }
                this.outputCurrency.Text = num2.ToString();
            }

        }

    }
}
