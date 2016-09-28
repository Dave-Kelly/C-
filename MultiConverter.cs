//David Kelly
//Student No.: c00193216
//Date: 21/09/2016
//Practical 1 Question Four: Allow user access functionality of all programs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiConverter
{
    public partial class MultiConverter : Form
    {
        string inputStringMC = string.Empty;      //Multi Converter - user input, as String, empty at start
        string outputStringMC = string.Empty;     //Multi Converter - conversion output, as String, empty at start
        double operandMC = 0.0;                   //Multi Converter - operand (Value to convert)
        double resultMC = 0.0;                    //Multi Converter - operand (Converted value)

        string inputStringCC = string.Empty;        //Currency converter - user input, as a String, empty at start
        string outputStringCC = string.Empty;       //Currency converter - conversion output, as a string, empty at start
        double operandCC = 0.0;                     //Currency Converter - operand (value to be converted)
        double resultCC = 0.0;                      //Currency converter - operand (converted value)

        string inputStringCalc = string.Empty;      //Calc - user input, as string, empty at start
        double operand1Calc = 0.0;                  //Calc - first operand
        double operand2Calc = 0.0;                  //Calc - second operand
        char operation;                             //Calc - operation
            

        public MultiConverter()
        {
            InitializeComponent();
        }
        //MULTICONVERTER************************************************
        private void btn1MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "1";       //Add 1 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box
        }

        private void btn2MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "2";       //Add 2 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box

        }

        private void btn3MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "3";       //Add 3 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box

        }

        private void btn4MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "4";       //Add 4 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box

        }

        private void btn5MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "5";       //Add 5 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box

        }

        private void btn6MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "6";       //Add 6 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box
        }

        private void btn7MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "7";       //Add 7 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box

        }

        private void btn8MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "8";       //Add 8 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box
        }

        private void btn9MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "9";       //Add 9 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box
        }

        private void btn0MC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += "0";       //Add 0 to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box
                    }

        private void btnDecimalMC_Click(object sender, EventArgs e)
        {
            this.inputMC.Text = "";     //Clear the input text box
            inputStringMC += ".";       //Add a decimal point to the end of the string
            this.inputMC.Text = inputStringMC;    //print the new string to the text box
                    }

        private void btnClearMC_Click(object sender, EventArgs e)
        {
            inputStringMC = string.Empty;       
            outputStringMC = string.Empty;   
            operandMC = 0.0;                   
            resultMC = 0.0;
            this.inputMC.Text = "";
            this.outputMC.Text = "";
            //Clear all text and initialize variables to 0
        }

        private void btnEqualMC_Click(object sender, EventArgs e)
        {
            if(inputStringMC != "")
            {
                double.TryParse(inputStringMC, out operandMC);
                if (this.cbMC1.SelectedIndex == 0)
                {
                    resultMC = operandMC / 12;
                }
                else if (this.cbMC1.SelectedIndex == 1)
                {
                    resultMC = ((operandMC * 9 / 5) + 32);
                }
                else if (this.cbMC1.SelectedIndex == 2)
                {
                    resultMC = operandMC * 0.79;
                }
                outputStringMC = resultMC.ToString();
                this.outputMC.Text = outputStringMC;
            }

        }//MultiConverter END*****************************************************

        //CURRENCY CONVERTER******************************************************
        private void btnOneCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "1";       //Add 1 to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnTwoCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "2";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnThreeCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "3";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnFourCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "4";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnFiveCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "5";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnSixCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "6";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnSevenCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "7";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnEightCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "8";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnNineCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "9";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnZeroCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += "0";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnDecimalCC_Click(object sender, EventArgs e)
        {
            this.inputCC.Text = "";     //Clear the input text box
            inputStringCC += ".";       //Add value to the end of the string
            this.inputCC.Text = inputStringCC;    //print the new string to the text box
        }

        private void btnClearCC_Click(object sender, EventArgs e)
        {
            inputStringCC = "";        
            outputStringCC = "";       
            operandCC = 0.0;                     
            resultCC = 0.0;
            this.inputCC.Text = "";
            this.outputCC.Text = "";
        }

        private void btnEqualsCC_Click(object sender, EventArgs e)
        {
            if (inputStringCC != "")
            {
                double.TryParse(inputStringCC, out operandCC);
                //EURO -> EURO
                if ((cbCC1.SelectedIndex == 0) && (cbCC2.SelectedIndex == 0))
                {
                    resultCC = operandCC * 1;
                }
                //EURO -> POUND
                else if ((cbCC1.SelectedIndex == 0) && (cbCC2.SelectedIndex == 1))
                {
                    resultCC = operandCC * 0.86;
                }
                //EURO -> DOLLAR
                else if ((cbCC1.SelectedIndex == 0) && (cbCC2.SelectedIndex == 2))
                {
                    resultCC = operandCC * 1.12;
                }
                //POUND -> EURO
                else if ((cbCC1.SelectedIndex == 1) && (cbCC2.SelectedIndex == 0))
                {
                    resultCC = operandCC * 1.17;
                }
                //POUND -> POUND
                else if ((cbCC1.SelectedIndex == 1) && (cbCC2.SelectedIndex == 1))
                {
                    resultCC = operandCC * 1;
                }
                //POUND -> DOLLAR
                else if ((cbCC1.SelectedIndex == 1) && (cbCC2.SelectedIndex == 2))
                {
                    resultCC = operandCC * 1.30;
                }
                //DOLLAR -> EURO
                else if ((cbCC1.SelectedIndex == 2) && (cbCC2.SelectedIndex == 0))
                {
                    resultCC = operandCC * 0.90;
                }
                //DOLLAR -> POUND
                else if ((cbCC1.SelectedIndex == 2) && (cbCC2.SelectedIndex == 1))
                {
                    resultCC = operandCC * 0.77;
                }
                //DOLLAR -> DOLLAR
                else if ((cbCC1.SelectedIndex == 2) && (cbCC2.SelectedIndex == 2))
                {
                    resultCC = operandCC * 1;
                }
                inputStringCC = "";
                operandCC = 0;
                outputStringCC = (resultCC.ToString());
                this.outputCC.Text = outputStringCC;
            }
        }//CurrencyConverter END********************************************

        //Calculator********************************************************
        private void btnOneCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "1";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnTwoCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "2";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnThreeCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "3";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnFourCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "4";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnFiveCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "5";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnSixCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "6";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnSevenCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "7";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnEightCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "8";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnNineCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "9";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnZeroCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += "0";                     //Add value to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnDecimalCalc_Click(object sender, EventArgs e)
        {
            this.inputCalc.Text = "";                   //Clear the input text box
            inputStringCalc += ".";                     //Add decimal point to the end of the string
            this.inputCalc.Text = inputStringCalc;      //print the new string to the text box
        }

        private void btnClearCalc_Click(object sender, EventArgs e)
        {
            inputStringCalc = string.Empty;
            operand1Calc = 0.0;
            operand2Calc = 0.0;
            this.inputCalc.Text = "";
        }

        private void btnAddCalc_Click(object sender, EventArgs e)
        {
            operation = '+';                                        //assign the operation to the variable
            double.TryParse(inputStringCalc, out operand1Calc);     //get the first number - convert to double and assign to variable
            inputStringCalc = string.Empty;                         //set the input string to empty
            this.inputCalc.Text = inputStringCalc;                  //clear the input text box, ready for next number     
        }

        private void btnSubCalc_Click(object sender, EventArgs e)
        {
            operation = '-';                                        //assign the operation to the variable
            double.TryParse(inputStringCalc, out operand1Calc);     //get the first number - convert to double and assign to variable
            inputStringCalc = string.Empty;                         //set the input string to empty
            this.inputCalc.Text = inputStringCalc;                  //clear the input text box, ready for next number 
        }

        private void btnMulCalc_Click(object sender, EventArgs e)
        {
            operation = '*';                                        //assign the operation to the variable
            double.TryParse(inputStringCalc, out operand1Calc);     //get the first number - convert to double and assign to variable
            inputStringCalc = string.Empty;                         //set the input string to empty
            this.inputCalc.Text = inputStringCalc;                  //clear the input text box, ready for next number 
        }

        private void btnDivCalc_Click(object sender, EventArgs e)
        {
            operation = '/';                                        //assign the operation to the variable
            double.TryParse(inputStringCalc, out operand1Calc);     //get the first number - convert to double and assign to variable
            inputStringCalc = string.Empty;                         //set the input string to empty
            this.inputCalc.Text = inputStringCalc;                  //clear the input text box, ready for next number 
        }

        private void btnEqualCalc_Click(object sender, EventArgs e)
        {
            if(inputStringCalc != "")
            {
                double resultCalc = 0.0;
                double.TryParse(inputStringCalc, out operand2Calc); //Parse the second number from string, assign to variable
                inputStringCalc = string.Empty;
                this.inputCalc.Text = inputStringCalc;              //Clear the input text box

                if(operation == '+')
                {
                    resultCalc = operand1Calc + operand2Calc;
                }
                else if(operation == '-')
                {
                    resultCalc = operand1Calc - operand2Calc;
                }
                else if(operation == '*')
                {
                    resultCalc = operand1Calc * operand2Calc;
                }
                else if(operation == '/')
                {
                    if(operand2Calc != 0)
                    {
                        resultCalc = operand1Calc / operand2Calc;
                    }
                }
                inputStringCalc = resultCalc.ToString();
                this.inputCalc.Text = inputStringCalc;
                operand1Calc = resultCalc;
                operand2Calc = 0.0;
            }
        }

        private void mCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
