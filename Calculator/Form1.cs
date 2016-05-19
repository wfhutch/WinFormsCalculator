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
        int counter = 0;

        string theOperator;

        //Cast the string entered for the operation to a double (for possible decimal points)
        //Set the operator sign for the switch statement to use
        //Increase the counter by one so the number of that particular operation can be displayed in textBox1
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "+";
            counter += 1;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "-";
            counter += 1;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "*";
            counter += 1;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "/";
            counter += 1;
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
            textBox1.Text += ("The answer to problem #" + counter + " is " + total2.ToString() + Environment.NewLine);
            //Reset value of total1 so it will be ready to recieve the next number
            total1 = 0;
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuCut_Click(object sender, EventArgs e)
        {
            //Check to see if a selection of text has been highlighted and cut it if there is.
            if (textBox1.SelectedText != "")
            {
                textBox1.Cut();
            }
        }

        private void menuUndo_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            //Check to see if anything has been highlighted and copy it if there is.
            if (textBox1.SelectionLength > 0)
            {
                textBox1.Copy();
            }
        }

        private void menuPaste_Click(object sender, EventArgs e)
        {
            //If there is Text on the clipboard the paste it.  If it isn't text don't paste.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox2.Paste();
                Clipboard.Clear();
            }
        }

        private void menuViewTextBoxes_Click(object sender, EventArgs e)
        {
            //This lines toggles the check next to View Text Boxes in menu
            menuViewTextBoxes.Checked = !menuViewTextBoxes.Checked;
            if(menuViewTextBoxes.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void menuViewLabels_Click(object sender, EventArgs e)
        {
            //This line toggles the check next to View Labels in menu
            menuViewLabels.Checked = !menuViewLabels.Checked;
            if(menuViewLabels.Checked)
            {
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
