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
    public partial class SessionReport : Form
    {
        sessionsreports SR;
        //private readonly object ParameterField;

        //public IEnumerable<ParameterDiscreteValue> Paramter { get; private set; }
        //public IEnumerable<ParameterDiscreteValue> ParamterFields { get; private set; }

        public SessionReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            SR = new sessionsreports();
            foreach (ParameterDiscreteValue V in SR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(V.Value);

        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Viewbtn_Click(object sender, EventArgs e)
        {
            SR.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = SR;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reportmenu form = new reportmenu();
            this.Hide();
            form.Show();
        }
    }
}
