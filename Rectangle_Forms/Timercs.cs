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
    public partial class Timercs : Form
    {
        public Timercs()
        {
            InitializeComponent();
            Bt_stop.Enabled = false;
        }
        int i;

        private void Show_timer(object sender, EventArgs e)
        {
            timer1.Stop();
            Bt_stop.Enabled = false;
            MessageBox.Show("Время вышло", "Таймер");
        }

        private void Bt_start_Click_1(object sender, EventArgs e)
        {
            i = (int)numerUP.Value;
            if (i < 0) { MessageBox.Show("Заданное время недопустимо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            timer1.Enabled = true;
            Bt_stop.Enabled = true;
        }

        private void Bt_stop_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            Bt_stop.Enabled = false;
            MessageBox.Show($"Таймер остановлен, осталось {i} секунд");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            i--;
            label2.Text = i.ToString();
            if (i == 0)
            {
                timer1.Stop();
                Bt_stop.Enabled = false;
                MessageBox.Show("Время вышло", "Таймер");
            }
        }
    }
}
