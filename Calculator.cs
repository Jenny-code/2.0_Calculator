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
        public string Opperand;
        public double entry1;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            BinaryDisplay.Text = "";
        }
        private void c(object sender, KeyPressEventArgs e)
        {
            textBoxResult.Text = "0";
            BinaryDisplay.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            BinaryDisplay.Text = "";
        }

        private void button_num_1_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "1";
            }
            else
            {
                textBoxResult.Text += "1";
            }
        }

        private void button_num_2_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "2";
            }
            else
            {
                textBoxResult.Text += "2";
            }
        }

        private void button_num_3_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "3";
            }
            else
            {
                textBoxResult.Text += "3";
            }
        }

        private void button_num_4_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "4";
            }
            else
            {
                textBoxResult.Text += "4";
            }
        }

        private void button_num_5_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "5";
            }
            else
            {
                textBoxResult.Text += "5";
            }
        }

        private void button_num_6_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "6";
            }
            else
            {
                textBoxResult.Text += "6";
            }
        }

        private void button_num_7_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "7";
            }
            else
            {
                textBoxResult.Text += "7";
            }
        }

        private void button_num_8_Click(object sender, EventArgs e)
        {

            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "8";
            }
            else
            {
                textBoxResult.Text += "8";
            }
        }

        private void button_num_9_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "9";
            }
            else
            {
                textBoxResult.Text += "9";
            }
        }

        private void button_num_0_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" && textBoxResult.Text != null)
            {
                textBoxResult.Text = "0";
            }
            else
            {
                textBoxResult.Text += "0";
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            entry1 = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "";
            Opperand = "*";
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            entry1 = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "";
            Opperand = "/";
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            entry1 = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "";
            Opperand = "+";
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            entry1 = Convert.ToDouble(textBoxResult.Text);
            textBoxResult.Text = "";
            Opperand = "-";
        }

        private void button_decimal_Click(object sender, EventArgs e)
        {
            if (!textBoxResult.Text.Contains("."))
            {
                textBoxResult.Text += ".";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text;
            }
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            double Equals;
            double entry2 = Convert.ToDouble(textBoxResult.Text);

            if (Opperand == "+")
            {

                Equals = entry1 + entry2;
                textBoxResult.Text = Convert.ToString(Equals);
                entry1 = Equals;
            }
            if (Opperand == "-")
            {
                Equals = entry1 - entry2;
                textBoxResult.Text = Convert.ToString(Equals);
                entry1 = Equals;
            }
            if (Opperand == "*")
            {
                Equals = entry1 * entry2;
                textBoxResult.Text = Convert.ToString(Equals);
                entry1 = Equals;
            }
            if (Opperand == "/")
            {
                if (entry2 == 0)
                {
                    textBoxResult.Text = "Nope";
                }
                else
                {
                    Equals = entry1 / entry2;
                    textBoxResult.Text = Convert.ToString(Equals);
                    entry1 = Equals;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_binary_Click(object sender, EventArgs e)
        {
            int result = int.Parse(textBoxResult.Text);
            List<char> rem = new List<char>();
            while (result >= 1)
            {
                if (result % 2 == 1)
                {
                    rem.Insert(0, '1');
                }
                else
                {
                    rem.Insert(0, '0');
                }
                result /= 2;
            }
            BinaryDisplay.Text = string.Join("", rem);
        }

        private void button_dec_Click(object sender, EventArgs e)
        {
            string bin_strng = BinaryDisplay.Text;
            int number = Convert.ToInt32(bin_strng, 2);
            BinaryDisplay.Text = number.ToString();
        }

        private void button_utf_Click(object sender, EventArgs e)
        {
            String letters = "abcdefghijklmnopqrstuvwxyz";
            String numericLocation = "";
            int decNum = int.Parse(textBoxResult.Text);
            while (decNum > 0)
            {
                int nexChar = (int)(Math.Log(decNum) / Math.Log(2));
                decNum -= (int)Math.Truncate(Math.Pow(2, nexChar));
                numericLocation = letters[nexChar] + numericLocation;
            }
            BinaryDisplay.Text = numericLocation;
        }
    }
}
