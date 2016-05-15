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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button9.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonZero.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + buttonPoint.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        double total1 = 0;
        double total2 = 0;

        string theOperator;

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "*";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "/";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (theOperator)
            {
                case "+":
                    total2 = total1 + double.Parse(txtDisplay.Text);
                    break;

                case "-":
                    total2 = total1 - double.Parse(txtDisplay.Text);
                    break;

                case "*":
                    total2 = total1 * double.Parse(txtDisplay.Text);
                    break;

                case "/":
                    total2 = total1 / double.Parse(txtDisplay.Text);
                    break;

                default:
                    total2 = 0;
                    break;

            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }
    }
}
