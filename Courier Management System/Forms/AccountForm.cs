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
    public partial class AccountForm : Form
    {
        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            emailText.Text = CustomerAccountInfo.user.Email;
            emailText.ReadOnly= true;

            nameText.Text = CustomerAccountInfo.user.Name;
            passwordText.Text = CustomerAccountInfo.user.Password;
            
            phoneText.Text = CustomerAccountInfo.user.Phone;
            addressText.Text = CustomerAccountInfo.user.Address;
            
            creditcardText.Text = CustomerAccountInfo.user.CreditCard;

            getAnalytics();


        }
        private int getIcome()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETGATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("res", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            int res;
            try
            {
                res = Convert.ToInt32(cmd.Parameters["res"].Value.ToString());
                // email.Text = res.ToString();
            }
            catch
            {
                res = 1;
            }
            return res;
        }
        

        private void getAnalytics()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "GETUSERACTIVITIES";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("email", CustomerAccountInfo.user.Email);

            cmd.Parameters.Add("nOrders", OracleDbType.Int32, ParameterDirection.Output);
            
            cmd.Parameters.Add("nComplains", OracleDbType.Int32, ParameterDirection.Output);
            
            cmd.Parameters.Add("totalSizeSum", OracleDbType.Int32, ParameterDirection.Output);

            

            try
            {
                cmd.ExecuteNonQuery();

                norders.Text = cmd.Parameters["nOrders"].Value.ToString();

                ncomplains.Text = cmd.Parameters["nComplains"].Value.ToString();

                totalsum.Text = cmd.Parameters["totalSizeSum"].Value.ToString();

            }
            catch
            {
                //res = 1;
            }
        }

        private void updateAccountInfo()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE Customers SET C_NAME =:name, C_PHNOE =:phone, Address=:address, C_CreditCard =: creditcard, c_password=:password  WHERE C_EMAIL=:email";


            cmd.Parameters.Add("email", CustomerAccountInfo.user.Email);

            cmd.Parameters.Add("name", CustomerAccountInfo.user.Name);
            cmd.Parameters.Add("phone", CustomerAccountInfo.user.Phone);
            cmd.Parameters.Add("address", CustomerAccountInfo.user.Address);
            cmd.Parameters.Add("creditcard", CustomerAccountInfo.user.CreditCard);
            cmd.Parameters.Add("password", CustomerAccountInfo.user.Password);

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
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            CustomerAccountInfo.user.Name = nameText.Text;
            CustomerAccountInfo.user.Phone = phoneText.Text;
            CustomerAccountInfo.user.Address = addressText.Text;
            CustomerAccountInfo.user.CreditCard = creditcardText.Text;
            CustomerAccountInfo.user.Password = passwordText.Text;

            updateAccountInfo();


        }

        private void goToCustomerForm()
        {
            CustomerFrom home = new CustomerFrom();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            goToCustomerForm();
        }
    }
}
