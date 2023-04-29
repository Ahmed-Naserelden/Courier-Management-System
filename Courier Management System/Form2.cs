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
    public partial class Form2 : Form
    {
        CrystalReport4 cr4;

        public Form2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            cr4 = new CrystalReport4();
            cr4.SetParameterValue(0, textBox1.Text);
            crystalReportViewer1.ReportSource = cr4;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            goToAdminHome();
        }
    }
}
