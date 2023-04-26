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
        private void goToHome()
        {
            CustomerFrom home = new CustomerFrom();
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
            email.Text = "an2071497@gmail.com";
            password.Text = "123456789";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            #region stor

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from customers where c_email=:emial and c_password=:password";
            cmd.CommandType = CommandType.Text;

            string emailtext = email.Text, passwordtext = password.Text;
            cmd.Parameters.Add("email", emailtext);
            cmd.Parameters.Add("password", passwordtext);

            OracleDataReader dr = cmd.ExecuteReader();

            string name = "", phone = "", creditCard = "", address = "";

            bool exist = false;

            if (dr.Read())
            {
                name = dr[0].ToString();
                creditCard = dr[1].ToString();
                phone = dr[4].ToString();
                address = dr[5].ToString();
                AccountInfo.user.Name = name;
                AccountInfo.user.Phone = phone;
                AccountInfo.user.Address = address;
                AccountInfo.user.CreditCard = creditCard;
                AccountInfo.user.Password = passwordtext;
                AccountInfo.user.Email= emailtext;
                exist = true;
            }
            
            dr.Close();
            if (exist == true)
            {
                // MessageBox.Show("Login Succesfully !!");
                CustomerFrom home = new CustomerFrom();
                home.Tag = this;
                home.Show(this);
                home.StartPosition = FormStartPosition.Manual;
                home.Location = this.Location;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login faild !! ");
            }
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
    }
}
