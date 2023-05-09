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
    public partial class DataGridViewForm_customer_ : Form
    {

        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";
        OracleConnection conn;

        public DataGridViewForm_customer_()
        {
            InitializeComponent();
        }

        private void DataGridViewForm_customer__Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            string cmdstr = "select DELIVERY_ID , C_EMAIL , D_EMAIL , SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE , STATUS , PROCESSDATE from deliveries where c_email =:email";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", CustomerAccountInfo.user.Email);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }
    }
}
