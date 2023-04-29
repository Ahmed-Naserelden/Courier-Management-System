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

namespace Courier_Management_System
{
    public partial class ComplainmentsMonitoringForm : Form
    {
        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;
        public ComplainmentsMonitoringForm()
        {
            InitializeComponent();
        }

        private void ComplainmentsMonitoringForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("seen");
            comboBox1.Items.Add("unseen");
            conn = new OracleConnection(ordb);
            conn.Open();
            comboBox1.SelectedItem = "seen"; // will show seen complain by admin at begining.
        }

        private void ComplainmentsMonitoringForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToCustomerForm();
        }
        private void goToCustomerForm()
        {
            MakeComplainmentForm home = new MakeComplainmentForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }
        private void showData()
        {
            string val = comboBox1.SelectedItem.ToString() == "seen" ? "1" : "0";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM COMPLAINMENTS WHERE STATUS=: stat";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("stat", val);

            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
