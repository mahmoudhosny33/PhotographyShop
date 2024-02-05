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
    public partial class photograhersForm : Form
    {
        List<int>arr = new List<int>();
        Int32 id;
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public photograhersForm()
        {
            InitializeComponent();
        }

        //reterive muiltple rows using stored procedures 
        private void Form1_Load(object sender, EventArgs e)
        {   
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GetPhotographer";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            while(dr.Read())
            {
                arr.Add(Convert.ToInt32(dr["PGID"]));
                combo_name.Items.Add(dr["pname"]);
            }
            dr.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        //Insert Rows(without using procedures)
        private void submit_button_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into PHOTOGRAPHER (pname,PADDRESS,PSALARY,PHONENUMBER,PBIRTHDAY) values (:name,:address,:salary,:number1,:birth)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", combo_name.Text);
                cmd.Parameters.Add("address", txt_address.Text);
                cmd.Parameters.Add("salary", Convert.ToInt32(txt_salary.Text));
                cmd.Parameters.Add("number1", txt_phone.Text);
                cmd.Parameters.Add("birth", monthCalendar1.SelectionRange.Start.ToShortDateString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
            }
            catch
            {
                MessageBox.Show("ERROR PLEASE TRY AGAIN");
            }
        }
        // retreive reterive muiltple rows wihtout stored procedures
        private void combo_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            id = arr.ElementAt(combo_name.SelectedIndex);
            cmd.Connection = conn;
            cmd.CommandText = "select pname,PADDRESS,PSALARY,PHONENUMBER,PBIRTHDAY from PHOTOGRAPHER where PGID=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id",id);
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                txt_address.Text = dr["PADDRESS"].ToString();
                txt_phone.Text = dr["PHONENUMBER"].ToString();
                txt_salary.Text = dr["PSALARY"].ToString();
                monthCalendar1.SetDate(Convert.ToDateTime(dr["PBIRTHDAY"]));
            }
            dr.Close();
        }
        // update tables 
        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update Photographer set pname=:name , paddress=:address,psalary=:salary ,PHONENUMBER=:phone,PBIRTHDAY=:birth where PGID=:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", combo_name.Text);
                cmd.Parameters.Add("address", txt_address.Text);
                cmd.Parameters.Add("salary", Convert.ToInt32(txt_salary.Text));
                cmd.Parameters.Add("phone", txt_phone.Text);
                cmd.Parameters.Add("birth", monthCalendar1.SelectionRange.Start.ToShortDateString());
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
                combo_name.Text = "";
                monthCalendar1.SetDate(DateTime.Now);
                txt_address.Text = "";
                txt_phone.Text = "";
                txt_salary.Text = "";
                txt_ID.Text = "";
                MessageBox.Show("Updated Successfully");
            }
            catch
            {
                MessageBox.Show("ERROR PLEASE TRY AGAIN");
            }
        }
        //delete row from the database
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from PHOTOGRAPHER where PGID =:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", id);
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deleted Successfully");
                    combo_name.Items.RemoveAt(combo_name.SelectedIndex);
                    monthCalendar1.SetDate(DateTime.Now);
                    txt_address.Text = "";
                    txt_phone.Text = "";
                    txt_salary.Text = "";
                    txt_ID.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("ERROR PLEASE TRY AGAIN");
            }
        }
        // select one row using stored procedure without refcursor
        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "GetPhotographerID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("phone", txt_phone.Text);
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                txt_ID.Text = cmd.Parameters["id"].Value.ToString();
            }
            catch {
                MessageBox.Show("ERROR PLEASE TRY AGAIN");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            this.Hide();
            form.Show();
            
        } 

        private void close_btn_Click(object sender, EventArgs e)
        {
            mainForm form = new mainForm();
            this.Close();
            form.Show();
        }
    }
}
