using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class MakeComplainmentForm : Form
    {
        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;
        public MakeComplainmentForm()
        {
            InitializeComponent();
        }

        private void ComplainmentForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            customerEmail.Text = CustomerAccountInfo.user.Email != null ? CustomerAccountInfo.user.Email : "";
            orderId.Text = Guid.NewGuid().ToString().Substring(10);
            comboBox1.Items.Add("cost");
            comboBox1.Items.Add("driver_behaviour");
            comboBox1.Items.Add("arrival_time");
        }

        private void ComplainmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void ComplaineBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO COMPLAINS VALUES(:id, :email, :cat ,:title, :description, :status)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", orderId.Text);
            cmd.Parameters.Add("email", customerEmail.Text);
            cmd.Parameters.Add("cat", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("title", complainTitle.Text);
            cmd.Parameters.Add("description", complainDescription.Text);
            cmd.Parameters.Add("status", "0");

            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Your complaints Sent Successfully.");
            }
            else
            {
                MessageBox.Show("Some Data Not Right.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToCustomerForm();
        }

        private void goToCustomerForm(){
            CustomerFrom home = new CustomerFrom();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void goToMontiring()
        {
            ComplainmentsMonitoringForm home = new ComplainmentsMonitoringForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void showcomplBtn_Click(object sender, EventArgs e)
        {
            goToMontiring();
        }

        private void orderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
