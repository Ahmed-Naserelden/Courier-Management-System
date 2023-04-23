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

        private void goToHome()
        {
            HomeForm home = new HomeForm();
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
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Single Row
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "USERINFO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("email", OracleDbType.Varchar2, "an2071497@gmail.com", ParameterDirection.Input);       // input Parameter
            cmd.Parameters.Add("cpassword", OracleDbType.Varchar2, "123456789", ParameterDirection.Input);             // input Parameter

            // cmd.Parameters.Add("email", "an2071497@gmail.com");
            // cmd.Parameters.Add("cpassword", "123456789");

            cmd.Parameters.Add("cname", OracleDbType.Varchar2, ParameterDirection.Output);                             // output Parameter
            cmd.Parameters.Add("caddress", OracleDbType.Varchar2, ParameterDirection.Output);                          // output Parameter
            cmd.Parameters.Add("cphone", OracleDbType.Varchar2, ParameterDirection.Output);                            // output Parameter
            cmd.Parameters.Add("ccrditcard", OracleDbType.Varchar2, ParameterDirection.Output);                        // output Parameter
            
            int r =  cmd.ExecuteNonQuery();
            try
            {
                AccountInfo.user.Email = email.Text;
                AccountInfo.user.Password = password.Text;
                AccountInfo.user.Name = cmd.Parameters["cname"].Value.ToString();
                AccountInfo.user.Address = cmd.Parameters["caddress"].Value.ToString();
                AccountInfo.user.Phone = cmd.Parameters["cphone"].Value.ToString();
                AccountInfo.user.CreditCard = cmd.Parameters["ccreditcard"].Value.ToString();
                
            }catch{
                MessageBox.Show("Login faild !! ");
            }
            goToHome();
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
