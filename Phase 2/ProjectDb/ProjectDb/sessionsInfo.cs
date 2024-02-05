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
    public partial class Form4 : Form
    {

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        List<int> arr = new List<int>();

        OracleDataAdapter od;
        DataSet ds;
        Int32 id;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GetPhotographer";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                arr.Add(Convert.ToInt32(dr["PGID"]));
                comboBox1.Items.Add(dr["pname"]);
            }
            dr.Close();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string or = "Data source=orcl;User Id=scott; Password=tiger;";
            string cm = "select p.pname,c.cname,s.sessionprice,s.sessiondate from sessions s,customer c,photographer p where s.cid=c.cid and s.pgid=p.pgid and p.pgid=:ids";
            od = new OracleDataAdapter(cm, or);
            od.SelectCommand.Parameters.Add("ids", id);
            ds = new DataSet();
            od.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = arr.ElementAt(comboBox1.SelectedIndex);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
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
