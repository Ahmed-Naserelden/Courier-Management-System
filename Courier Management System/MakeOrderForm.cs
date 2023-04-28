using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using Courier_Management_System.Models;
using System.Diagnostics;

namespace Courier_Management_System
{
    public partial class MakeOrderForm : Form
    {

        public static int newOrderId = 4;
        public MakeOrderForm()
        {
            InitializeComponent();
        }

        void goToCustomerForm()
        {
            CustomerFrom home = new CustomerFrom();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }



        string ordb = "Data Source= ORCL; User Id=scott; Password=tiger";
        OracleConnection conn;
        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            //CustomerAccountInfo.user.Email = "an2071497@gmail.com";
            textBox1.Text = CustomerAccountInfo.user.Email;
        }

        private void MakeOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Confirm order request:", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                string email = textBox1.Text;
                int size = Convert.ToInt32(textBox3.Text);
                string sourceAddress = textBox2.Text;
                string destinationAddress = textBox4.Text;
                string date = dateTimePicker1.Text;

                //string query = "INSERT INTO DELIVERIES (DELIVERY_ID)" +
                //    "VALUES (order_id_counter.nextval)";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO DELIVERIES (DELIVERY_ID, C_EMAIL, SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE, PROCESSDATE)" +
                    " VALUES (:id, :email, :source, :destination, :sizeo, :dateo)";
                cmd.CommandType = CommandType.Text;


                cmd.Parameters.Add("id", Guid.NewGuid().ToString().Substring(10));
                cmd.Parameters.Add("email", email);
                cmd.Parameters.Add("source", sourceAddress);
                cmd.Parameters.Add("destination", destinationAddress);
                cmd.Parameters.Add("sizeo", size);
                cmd.Parameters.Add("dateo", DateTime.Now);

                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Done");
                    goToCustomerForm();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void back_click(object sender, EventArgs e)
        {
            goToCustomerForm();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}