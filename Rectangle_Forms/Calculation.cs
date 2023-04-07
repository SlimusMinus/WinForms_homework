using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectangle_Forms
{
    public partial class Calculation : Form
    {
        public double a, b;
        public char c;
        public Calculation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            label1.Text = "";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(label1.Text);
            label1.Text = Convert.ToString(a * a);
        }

        private void button_zpt_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(label1.Text);
            switch (c)
            {
                case '+':
                    label1.Text = Convert.ToString(a + b); break;
                case '-':
                    label1.Text = Convert.ToString(a - b); break;
                case '/':
                    {
                        if (b == 0)
                            MessageBox.Show("На ноль делить нельзя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        label1.Text = Convert.ToString(a / b);
                    }
                    break;
                case '*':
                    label1.Text = Convert.ToString(a * b); break;

            }
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(label1.Text);
            c = '*';
            label1.Text = "";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(label1.Text);
            c = '+';
            label1.Text = "";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(label1.Text);
            c = '-';
            label1.Text = "";
        }

        private void button_divided_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(label1.Text);
            c = '/';
            label1.Text = "";
        }


    }
}
