using Courier_Management_System.Models;
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
    public partial class DriverAccountInfoForm : Form
    {
        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;

        public DriverAccountInfoForm()
        {
            InitializeComponent();
        }

        private void DriverAccountInfoForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            emailText.Text = DriverAccountInfo.user.Email;
            emailText.ReadOnly = true;

            nameText.Text = DriverAccountInfo.user.Name;
            passwordText.Text = DriverAccountInfo.user.Password;

            phoneText.Text = DriverAccountInfo.user.Phone;
            addressText.Text = DriverAccountInfo.user.Address;

            creditcardText.Text = DriverAccountInfo.user.CreditCard;
            
        }

       
        private void backBtn_Click(object sender, EventArgs e)
        {
          
            goToDriverFormForm();
        }

        /*private void updateAccountInfo()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE DRIVERS SET D_NAME =:name, D_PHNOE =:phone, D_Address=:address, D_CreditCard =: creditcard, D_password=:password  WHERE D_EMAIL=:email";


            cmd.Parameters.Add("email", DriverAccountInfo.user.Email);

            cmd.Parameters.Add("name", DriverAccountInfo.user.Name);
            cmd.Parameters.Add("phone", DriverAccountInfo.user.Phone);
            cmd.Parameters.Add("address", DriverAccountInfo.user.Address);
            cmd.Parameters.Add("creditcard", DriverAccountInfo.user.CreditCard);
            cmd.Parameters.Add("password", DriverAccountInfo.user.Password);

            try
            {
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("All Is Update.");
                }
                else
                {
                    MessageBox.Show("failed.");
                }
            }
            catch
            {
                MessageBox.Show("failed.");
            }
        }*/


        private void updateAccountInfo()
        {

            DriverAccountInfo.user.Name = nameText.Text;
            DriverAccountInfo.user.Phone = phoneText.Text;
            DriverAccountInfo.user.Address = addressText.Text;
            DriverAccountInfo.user.CreditCard = creditcardText.Text;
            DriverAccountInfo.user.Password = passwordText.Text;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            cmd.CommandText = "UPDATE DRIVERS SET D_NAME =:name, D_PHONE =:phone, D_ADDRESS=:address, D_CREDITCARD_NUM =: creditcard, D_password=:password  WHERE D_EMAIL=:email";



            cmd.Parameters.Add("name", DriverAccountInfo.user.Name);
            cmd.Parameters.Add("phone", DriverAccountInfo.user.Phone);
            cmd.Parameters.Add("address", DriverAccountInfo.user.Address);
            cmd.Parameters.Add("creditcard", DriverAccountInfo.user.CreditCard);
            cmd.Parameters.Add("password", DriverAccountInfo.user.Password);
            cmd.Parameters.Add("email", DriverAccountInfo.user.Email);

            int r = cmd.ExecuteNonQuery();
            try
            {

                if (r != -1)
                {
                    MessageBox.Show("All Is Update.");
                }
                else
                {
                    MessageBox.Show("failed.");
                }
            }
            catch
            {
                MessageBox.Show("some Error.");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DriverAccountInfo.user.Name = nameText.Text;
            DriverAccountInfo.user.Phone = phoneText.Text;
            DriverAccountInfo.user.Address = addressText.Text;
            DriverAccountInfo.user.CreditCard = creditcardText.Text;
            DriverAccountInfo.user.Password = passwordText.Text;

            updateAccountInfo();


        }

        private void goToDriverFormForm()
        {
            DriverForm home = new DriverForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void DriverAccountInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            updateAccountInfo();
        }
    }
}
