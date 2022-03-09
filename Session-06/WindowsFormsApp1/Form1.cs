using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
            this.textBox2.Text += "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox2.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ValueAndOperatorType((int)MathOperations.Add);
            //Calculator.Calc calc = new Calculator.Calc();
            //this.textBox2.Text += calc.Add();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ValueAndOperatorType((int)MathOperations.Minus);
            //Calculator.Calc calc = new Calculator.Calc();
            //this.textBox2.Text += calc.Minus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ValueAndOperatorType((int)MathOperations.Multiply);
            //Calculator.Calc calc = new Calculator.Calc();
            //this.textBox2.Text += calc.Mult();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ValueAndOperatorType(((int)MathOperations.Divide));
            //Calculator.Calc calc = new Calculator.Calc(); 
            //this.textBox2.Text += calc.Div();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!this.textBox2.Text.Contains('.'))
            {
                this.textBox2.Text += ".";
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ValueAndOperatorType(((int)MathOperations.Power));
            //Calculator.Calc calc = new Calculator.Calc(); 
            //this.textBox2.Text += calc.Power();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ValueAndOperatorType(((int)MathOperations.Squere));
            //Calculator.Calc calc = new Calculator.Calc(); 
            //this.textBox2.Text += calc.Square();
        }
        private double firstNum = 0.0d;
        private double secondNum = 0.0d;
        private double result = 0d;
        private int operatorType = (int)MathOperations.NoOperator;
        public enum MathOperations
        {
            NoOperator=0,
            Add=1,
            Minus=2,
            Divide=3,
            Multiply=4,
            Power=5,
            Squere=6
        }
        private void ValueAndOperatorType(int operation)
        {
            operatorType=operation;
            
            firstNum = Convert.ToDouble(textBox2.Text);
            this.textBox2.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(this.textBox2.Text);
            switch(operatorType)
            {
                case (int)MathOperations.Add:
                    result = firstNum + secondNum;
                    break;
                case (int)MathOperations.Minus:
                    result = firstNum - secondNum;
                    break;
                case (int)MathOperations.Multiply:
                    result = firstNum * secondNum;
                    break;
                case (int)MathOperations.Divide:
                    result = firstNum / secondNum;
                    break;
                case (int)MathOperations.Power:
                    result = Math.Pow(firstNum,secondNum);
                    break;
                case (int)MathOperations.Squere:
                    result = Math.Sqrt(firstNum);
                    break;
            }
            this.textBox2.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "0";
        }
    }
}
