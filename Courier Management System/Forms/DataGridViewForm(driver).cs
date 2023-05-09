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
using Courier_Management_System.Models;

namespace Courier_Management_System.Forms
{

    public partial class DataGridViewForm_driver_ : Form
    {

         DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";
        OracleConnection conn;

        public DataGridViewForm_driver_()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_driver__Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            conn = new OracleConnection(ordb);
            conn.Open();

            string cmdstr = "select DELIVERY_ID , C_EMAIL, D_EMAIL, DESTINATOIN_ADDRESS, SOURCE_ADDRESS , PAKAGE_SIZE , STATUS ,PROCESSDATE from deliveries where STATUS='pending approval' ";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", DriverAccountInfo.user.Email);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //cmd.CommandText = "view_all_requests";
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);


            //OracleDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dataGridView1.DataSource = dt;
        }

        private void accept_request_click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
