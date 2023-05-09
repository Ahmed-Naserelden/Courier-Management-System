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
    public partial class DriverHome : Form
    {

        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";
        OracleConnection conn;

        public DriverHome()
        {
            InitializeComponent();
        }

        private void DriverHome_Load(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            label1.Text = DriverAccountInfo.user.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

           
            string cmdstr = "select DELIVERY_ID , C_EMAIL, D_EMAIL, DESTINATOIN_ADDRESS, SOURCE_ADDRESS , PAKAGE_SIZE , STATUS ,PROCESSDATE " +
                "from deliveries " +
                "where d_email =:email AND STATUS!='done'";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", DriverAccountInfo.user.Email);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            
            string cmdstr = "select DELIVERY_ID , C_EMAIL, D_EMAIL, DESTINATOIN_ADDRESS, SOURCE_ADDRESS , PAKAGE_SIZE , STATUS ,PROCESSDATE from deliveries where d_email =:email AND STATUS='done'";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", label1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
