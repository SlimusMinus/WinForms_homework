using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography.Xml;

namespace Rectangle_Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public string Coord_mouse_ToString(MouseEventArgs ev)
        {
            return $"� = {ev.X.ToString()} y = {ev.Y.ToString()}";
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coord_mouse_ToString(e);
        }

        private void label1_MouseClick(object sender, MouseEventArgs mea)
        {
            string str = $"������ = {label1.Size.Height} ������ = {label1.Size.Width}";
            if (mea.Button == MouseButtons.Left)
            {
                if ((ModifierKeys & Keys.Control) == Keys.Control)
                    Application.Exit();
                if (mea.X == 744 || mea.Y == 431 || mea.X == 0 || mea.Y == 0)
                    MessageBox.Show("�� �� ������� ��������������");
                else if (mea.X < 745 || mea.Y < 431 || mea.X > 0 || mea.Y > 0)
                    MessageBox.Show("�� ������ ��������������");
            }

            else if (mea.Button == MouseButtons.Right)
                MessageBox.Show("������ ������ ������ ����", str, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = Coord_mouse_ToString(e);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs mea)
        {
            if ((ModifierKeys & Keys.Control) == Keys.Control)
                Application.Exit();
            if (mea.X < 11 || mea.Y < 8 || mea.X > 745|| mea.Y > 432)
                MessageBox.Show("�� ����� �� ������� ��������������");
        }
    }
}