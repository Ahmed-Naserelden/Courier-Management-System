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
        CrystalReport2 CR2 ;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CR2 = new CrystalReport2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CR2.SetParameterValue(0, textBox1.Text);
            crystalReportViewer2.ReportSource = CR2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
