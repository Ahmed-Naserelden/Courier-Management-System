using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            conn.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            #region stor
            if(searchInCustomers())
            {
                goToCustomerHome();
                return;
            }
            if (searchInDrivers())
            {
                goToDriverHome();
                return;
            }
            if (searchInAdmins())
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

        private bool searchInCustomers()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from customers where c_email=:email and c_password=:password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email.Text);
            cmd.Parameters.Add("password", password.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            bool flage = false;
            if (dr.Read())
            {

                CustomerAccountInfo.user.Password = password.Text;
                CustomerAccountInfo.user.Email = email.Text;

                CustomerAccountInfo.user.Name = dr[0].ToString(); ;
                CustomerAccountInfo.user.Phone = dr[4].ToString(); ;
                CustomerAccountInfo.user.Address = dr[5].ToString();
                CustomerAccountInfo.user.CreditCard = dr[1].ToString(); ;

                current_user = email.Text;
                flage = true;
            }
            dr.Close();
            return flage;
        }

        private bool searchInDrivers()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from drivers where d_email=:email and d_password=:password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email.Text);
            cmd.Parameters.Add("password", password.Text);
            
            OracleDataReader dr = cmd.ExecuteReader();

            bool flage = false;
            if (dr.Read())
            {
                DriverAccountInfo.user.Password = password.Text;
                DriverAccountInfo.user.Email = email.Text;

                DriverAccountInfo.user.Name = dr[0].ToString(); ;
                DriverAccountInfo.user.Phone = dr[4].ToString(); ;
                DriverAccountInfo.user.Address = dr[5].ToString();
                DriverAccountInfo.user.CreditCard = dr[1].ToString(); ;
                DriverAccountInfo.user.Password = password.Text;
                DriverAccountInfo.user.Email = email.Text;

                current_user = email.Text;
                flage = true;
            }
            dr.Close();
            return flage;
        }

        private bool searchInAdmins()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from admins where EMAIL=:email and ADMINPASSWORD=:password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("email", email.Text);
            cmd.Parameters.Add("password", password.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            bool flage = false;
            if (dr.Read())
            {
                AdminAccountInfo.user.Password = password.Text;
                AdminAccountInfo.user.Email = email.Text;

                current_user = email.Text;
                flage = true;
            }
            dr.Close();
            return flage;
        }
    }
}
