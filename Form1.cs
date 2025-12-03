using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox3.Text.Trim();
            string serverIP = textBox2.Text.Trim();
            string portText = textBox1.Text.Trim();

            

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("�̸��� �Է��ϼ���.", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(serverIP))
            {
                MessageBox.Show("IP �ּҸ� �Է��ϼ���.", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(portText, out int port) || port < 1024 || port > 65534)
            {
                MessageBox.Show("��Ʈ�� 1024~65534 ������ ���ڿ��� �մϴ�.", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Hide();
            Form2 f2 = new Form2(userName, serverIP, port);
            f2.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}