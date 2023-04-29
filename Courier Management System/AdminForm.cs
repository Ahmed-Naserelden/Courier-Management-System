using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courier_Management_System.Models;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Courier_Management_System
{
    public partial class AdminForm : Form
    {
        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Click(object sender, EventArgs e)
        {
            updatebtn.Visible = false;
            search.Visible = false;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "viewCustInfo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);


            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }


        private void viewDriver_Click(object sender, EventArgs e)
        {
            updatebtn.Visible = false;
            search.Visible = false;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "viewDriverInfo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            label1.Text = LoginForm.current_user;

        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            updatebtn.Visible = false;
            search.Visible = false;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "view_all_requests";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }
        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;

        private void complainmentsBtn_Click(object sender, EventArgs e)
        {
            updatebtn.Visible = true;
            search.Visible = true;

            
            string cmdstr = "SELECT * FROM COMPLAINS WHERE status =:stat";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("status", "0");
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }


        private void updatebtn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cmdstr = "SELECT * FROM COMPLAINS WHERE C_EMAIL =:email";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", search.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}