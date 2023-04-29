using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Collections.Generic;
using Courier_Management_System.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Courier_Management_System
{
    public partial class CustomerFrom : Form
    {
        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";

        public CustomerFrom()
        {
            InitializeComponent();
        }

        void goToMakeOrderForm()
        {
            MakeOrderForm home = new MakeOrderForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        void goOut()
        {
            LoginForm home = new LoginForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        void goToAccountForm()
        {
            AccountForm home = new AccountForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        void goToComplainmentForm() {
            MakeComplainmentForm form = new MakeComplainmentForm();
            form.Tag = this;
            form.Show(this);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
        } 
        
        private void HomeForm_Load(object sender, EventArgs e)
        {
            label1.Text = CustomerAccountInfo.user.Name;
            label3.Text = CustomerAccountInfo.user.Name;

            string cmdstr = "select DELIVERY_ID, C_EMAIL, SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE from deliveries where c_email =:email";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", CustomerAccountInfo.user.Email);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }


        private void WriteAcomplaint_click(object sender, EventArgs e)
        {
            goToComplainmentForm();
        }

        private void Book_Arequest_click(object sender, EventArgs e)
        {
            goToMakeOrderForm();

        }

        private void ViewMyOrders_click(object sender, EventArgs e)
        {
            string cmdstr = "select C_EMAIL, SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE from deliveries where c_email =:email";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", CustomerAccountInfo.user.Email);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            goOut();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            goToAccountForm();
        }
    }

}