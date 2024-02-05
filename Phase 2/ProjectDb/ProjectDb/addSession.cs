using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ProjectDb
{
    public partial class Sessions : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        List<int> arr = new List<int>();
        Int32 PHid;
        public Sessions()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PHid = arr.ElementAt(combo_ID.SelectedIndex);
        }

        private string getCustomerID()
        {
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            string cid = "";
            cmd2.CommandText = "select cid from customer where cemail = :email";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("email", txt_email.Text);
            OracleDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                cid = dr["cid"].ToString();
            }
            return cid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "insert into CUSTOMER (CNAME,CEMAIL,CADDRESS,CPHONENUMBER) values (:name,:email,:address,:phonenum)";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("name", txt_name.Text);
                cmd2.Parameters.Add("email", txt_email.Text);
                cmd2.Parameters.Add("address", txt_address.Text);
                cmd2.Parameters.Add("phonenum", txt_phone.Text);
                cmd2.ExecuteNonQuery();
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "insert into sessions (sessionprice,height,width,sessiondate,PGID,CID) values (:sprice,:height,:width,:sdate,:phgid,:cuid)";
                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.Add("sprice", txt_price.Text);
                cmd3.Parameters.Add("height", txt_height.Text);
                cmd3.Parameters.Add("width", txt_width.Text);
                cmd3.Parameters.Add("sdate", monthCalendar1.SelectionRange.Start.ToLongDateString());
                cmd3.Parameters.Add("phid", PHid);
                cmd3.Parameters.Add("cuid", getCustomerID());
                cmd3.ExecuteNonQuery();
                if(txt_ccn.Text != "")
                {
                    cmd3 = new OracleCommand();
                    cmd3.Connection = conn;
                    cmd3.CommandText = "insert into Payments (PCARDNUMBER,PTOTALAMOUNT,PAYMENTDATE,CID) values (:ccn,:totalpay,:pdate,:pcid)";
                    cmd3.Parameters.Add("ccn", txt_ccn.Text);
                    cmd3.Parameters.Add("totalpay", txt_price.Text);
                    cmd3.Parameters.Add("pdate", DateTime.Today.ToLongDateString());
                    cmd3.Parameters.Add("pcid", getCustomerID());
                    cmd3.ExecuteNonQuery();
                }
                MessageBox.Show("Inserted Successfully");
                txt_address.Text = "";
                txt_ccn.Text = "";
                txt_email.Text = "";
                txt_height.Text = "";
                txt_name.Text = "";
                txt_phone.Text = "";
                txt_price.Text = "";
                txt_width.Text = "";
                combo_ID.Text = "";
                monthCalendar1.SetDate(DateTime.Now);
            } catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Sessions_Load(object sender, EventArgs e)
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
                combo_ID.Items.Add(dr["pname"]);
            }
            dr.Close();
        }

        private void Sessions_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerInfo form5 = new customerInfo();
            this.Hide();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            this.Hide();
            form.Show();
        }
    }
}
