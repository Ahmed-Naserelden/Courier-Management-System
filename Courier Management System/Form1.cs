using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_Management_System
{
    public partial class Form1 : Form
    {
        CrystalReport3 cr;

        public Form1()
        {
            InitializeComponent();
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


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr = new CrystalReport3();
            crystalReportViewer1.ReportSource = cr;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goToAdminHome();   
        }
    }
}
