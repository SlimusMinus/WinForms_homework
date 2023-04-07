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
    public partial class Заголовок : Form
    {
        public Заголовок()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timercs timercs = new Timercs();
            timercs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation();
            calculation.ShowDialog();
        }
    }
}
