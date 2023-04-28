using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courier_Management_System.Models;
using Microsoft.Win32;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Courier_Management_System
{
    public partial class LoginForm : Form
    {
        public static string current_user = "";
        
        OracleConnection conn;
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        public LoginForm()
        {
            InitializeComponent();
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

        private void getUserOrder(string email)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "customer_orders";
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add("email", email);
            cmd.Parameters.Add("orders", OracleDbType.RefCursor, ParameterDirection.Output);     
            
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

            }
            dr.Close();

        }

        private void goToDriverHome()
        {
            DriverForm home = new DriverForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void goToCustomerHome()
        {
            CustomerFrom home = new CustomerFrom();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void goToAdminHome()
        {
            AdminForm home = new AdminForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            //user  = new User();
            conn.Open();
            //email.Text = "admin@a.com";
            //password.Text = "admin";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            #region stor
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd2 = new OracleCommand();
            OracleCommand cmd3 = new OracleCommand();
            string emailtext = email.Text, passwordtext = password.Text;
            
            // cmd
            cmd.Connection = conn;
            cmd.CommandText = "select * from customers where c_email=:email and c_password=:password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", emailtext);
            cmd.Parameters.Add("password", passwordtext);

            //cmd2
            cmd2.Connection = conn;
            cmd2.CommandText = "select * from drivers where d_email=:email and d_password=:password";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("email", emailtext);
            cmd2.Parameters.Add("password", passwordtext);

            //cmd3
            cmd3.Connection = conn;
            cmd3.CommandText = "select * from admins where email=:email and ADMINPASSWORD=:password";
            cmd3.CommandType = CommandType.Text;
            cmd3.Parameters.Add("email", emailtext);
            cmd3.Parameters.Add("password", passwordtext);
            current_user = emailtext;

            string name = "", phone = "", creditCard = "", address = "";
            bool exist = false;
            

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name = dr[0].ToString();
                creditCard = dr[1].ToString();
                phone = dr[4].ToString();
                address = dr[5].ToString();
                CustomerAccountInfo.user.Name = name;
                CustomerAccountInfo.user.Phone = phone;
                CustomerAccountInfo.user.Address = address;
                CustomerAccountInfo.user.CreditCard = creditCard;
                CustomerAccountInfo.user.Password = passwordtext;
                CustomerAccountInfo.user.Email= emailtext;
                exist = true;
            }
            dr.Close();
            if(exist == true)
            {
                goToCustomerHome();
                return;
            }
            OracleDataReader dr2 = cmd.ExecuteReader();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                
                exist = true;
            }
            dr2.Close();
            if (exist == true)
            {
                goToDriverHome();
                return;
            }

            OracleDataReader dr3 = cmd.ExecuteReader();
            dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                exist = true;
            }
            dr3.Close();
            if (exist == true)
            {
                goToAdminHome();
                return;
            }

            MessageBox.Show("Login faild !! ");
            
            #endregion
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Tag = this;
            register.StartPosition = FormStartPosition.Manual;
            register.Location = this.Location;
            register.Show(this);
            this.Hide();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
