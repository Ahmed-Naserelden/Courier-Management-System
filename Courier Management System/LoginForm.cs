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
                exist = true;
            }

            if (exist == true)
            {
                // MessageBox.Show("Login Succesfully !!");
                HomeForm home = new HomeForm();
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
            //dr.Close();
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
