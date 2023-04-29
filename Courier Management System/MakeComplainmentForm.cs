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
        }

        private void ComplainmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void ComplaineBtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO complainments VALUES(:id, :email, :title, :description, :status)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", orderId.Text);
            cmd.Parameters.Add("email", customerEmail.Text);
            cmd.Parameters.Add("title", complainTitle.Text);
            cmd.Parameters.Add("description", complainDescription.Text);
            cmd.Parameters.Add("status", 0);

            int r = cmd.ExecuteNonQuery();
            if(r != -1)
            {
                MessageBox.Show("Your Complainment Sent Successfully.");
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
    }
}
