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
    public partial class reportmenu : Form
    {
        public reportmenu()
        {
            InitializeComponent();
        }

        private void SessionRep_Click(object sender, EventArgs e)
        {
            SessionReport re = new SessionReport();
            this.Hide();
            re.Show();
        }

        private void photographerinfo_Click(object sender, EventArgs e)
        {
           photographerinfoReport pr = new photographerinfoReport();
            this.Hide();
            pr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            this.Hide();
            form.Show();
        }

        private void reportmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
