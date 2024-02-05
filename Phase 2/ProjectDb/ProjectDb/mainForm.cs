using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDb
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            photograhersForm form1 = new photograhersForm();
            this.Hide();
            form1.Show();
        }

        private void session_btn_Click(object sender, EventArgs e)
        {
            Sessions form3 = new Sessions();
            this.Hide();
            form3.Show();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            photograhersForm form1 = new photograhersForm();
            this.Close();
            form1.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            reportmenu menu = new reportmenu();
            this.Hide();
            menu.Show();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
