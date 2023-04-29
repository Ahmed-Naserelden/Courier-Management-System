using Courier_Management_System.Models;
using Microsoft.Win32;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Courier_Management_System
{
    public partial class RegisterForm : Form
    {
        OracleConnection conn;
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_form_Load(object sender, EventArgs e)
        {
            MajorcomboBox1.Items.Add("User");
            MajorcomboBox1.Items.Add("Driver");
            conn = new OracleConnection(ordb);
            conn.Open();
            
        }
        
        private void register_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            //login.Show();
            login.Tag = this;
            login.StartPosition = FormStartPosition.Manual;

            login.Location = this.Location;
            login.Show(this);
            this.Hide();
        }

        void goToLogin()
        {
            LoginForm home = new LoginForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }
        private void Register_button_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            User user = new User();
            
            user.Name = First_name_textbox.Text + " " + Last_name_textbox.Text;
            user.Email = Email_textbox.Text;
            user.Phone = Phone_textbox.Text;
            user.Password = Password_textbox.Text;
            
            try
            {
                user.Major = MajorcomboBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show(":( Select Major");
            }
            user.Address = Address_textbox.Text;
            user.CreditCard = credit_card_textBox.Text;

            if (Password_textbox.Text != RepeatPassword_textBox1.Text)
            {
                passnotequal.Visible = true;
            }
            else
            {
                passnotequal.Visible = false;
            }

            if (user.Name != " " && user.Email != "" &&
                user.Phone != "" && user.Password != "" && 
                user.Password == RepeatPassword_textBox1.Text &&
                user.Major != "" && user.Address != "" &&
                user.CreditCard != ""
                ){

                string table = "drivers";
                if(user.Major == "User")
                    table = "customers";
                

                string qu = "insert into " + table + " values (:c_name,:c_reditcard_num,:c_email,:c_password,:c_phone,:c_address)";
                cmd.CommandText = qu;// "insert into customers values (:c_name,:c_reditcard_num,:c_email,:c_password,:c_phone,:c_address)";

                cmd.Parameters.Add("c_name", user.Name);
                cmd.Parameters.Add("c_reditcard_num", user.CreditCard);
                cmd.Parameters.Add("c_email", user.Email);
                cmd.Parameters.Add("c_password", user.Password);
                cmd.Parameters.Add("c_phone", user.Phone);
                cmd.Parameters.Add("c_address", user.Address);
               

                
                try
                {
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                    {
                        // MessageBox.Show("Wellcome :) You Now Have an Account :)");
                        goToLogin();
                    }
                }
                catch {
                    MessageBox.Show(":( Some Error Occure");
                }
                
                //passnotequal.Visible = false;
            }
            else
            {
                MessageBox.Show(":( Some Field Not Valid! :(");
            }
        }

        private void MajorcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
