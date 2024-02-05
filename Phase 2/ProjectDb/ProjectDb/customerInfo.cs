using Oracle.DataAccess.Client;
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
    public partial class customerInfo : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleDataAdapter od;
        DataSet ds;
        OracleCommandBuilder builder;
        public customerInfo()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string or = "Data source=orcl;User Id=scott; Password=tiger;";
            string cm = "select * from customer";
            od = new OracleDataAdapter(cm, or);
            ds = new DataSet();
            od.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(od);
            od.Update(ds.Tables[0]);
            MessageBox.Show("succeded update");
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sessions form = new Sessions();
            this.Hide();
            form.Show();
        }
    }
}
