using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace ProjectDb
{
    public partial class photographerinfoReport : Form
    {
        photographer_info PR;
        public photographerinfoReport()
        {
            InitializeComponent();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = PR;
        }

        private void photographerinfoReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void photographerinfoReport_Load(object sender, EventArgs e)
        {
            PR = new photographer_info();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reportmenu form = new reportmenu();
            this.Hide();
            form.Show();
        }
    }
}
