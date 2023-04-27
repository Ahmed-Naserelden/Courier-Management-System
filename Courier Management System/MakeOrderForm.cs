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
        public MakeOrderForm()
        {
            InitializeComponent();
        }


        string ordb = "Data Source= ORCL; User Id=scott; Password=tiger";
        OracleConnection conn;
        private void MakeOrderForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            CustomerAccountInfo.user.Email = "an2071497@gmail.com";
            textBox1.Text = CustomerAccountInfo.user.Email;

        }

        private void MakeOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            int size = Convert.ToInt32(textBox3.Text);
            string sourceAddress = textBox2.Text;
            string destinationAddress = textBox4.Text;
            string date = dateTimePicker1.Text;


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO DELIVERIES (DELIVERY_ID, C_EMAIL, SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE, PROCESSDATE)" +
                " VALUES (:Id, :email, :source, :destination, :sizeo, :dateo)";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("Id", 103);
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("source", sourceAddress);
            cmd.Parameters.Add("destination", destinationAddress);
            cmd.Parameters.Add("sizeo", size);
            cmd.Parameters.Add("dateo", DateTime.Now);



            int r = cmd.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Done");
            }
            else
            {
                MessageBox.Show("Failed");
            }

        }
    }
}
