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
using Courier_Management_System.Models;

namespace Courier_Management_System
{
    public partial class DriverForm : Form
    {
        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;

        public DriverForm()
        {
            InitializeComponent();
        }

        private void ViewAllOrders_click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "view_all_requests";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);


            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
        }

        private void ViewAccountInfo_click(object sender, EventArgs e)
        {

        }

        private void ResignationRequest_click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm resignation request:", "Delete row", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "Delete from Drivers where D_NAME=:name ";
               c.Parameters.Add("name", DriverAccountInfo.user.Name);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Actor deleted");
                   
                }
            }
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
