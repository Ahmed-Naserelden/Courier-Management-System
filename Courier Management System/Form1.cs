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
        CrystalReport1 CR1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport1() ;
        }
    }
}
