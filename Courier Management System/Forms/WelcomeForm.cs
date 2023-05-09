using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_Management_System
{
    public partial class WelcomeForm : Form
    {

        private System.Windows.Forms.Timer tmr;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        //void goToLogin()
        //{
        //    Thread.Sleep(TimeSpan.FromSeconds(5));
        //    LoginForm home = new LoginForm();
        //    home.Tag = this;
        //    home.Show(this);
        //    home.StartPosition = FormStartPosition.Manual;
        //    home.Location = this.Location;

        //}

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //design
            panel2.BackColor = Color.FromArgb(200, 0, 0, 0);
            this.MinimumSize = new Size(797, 444);
            this.MaximumSize = new Size(797, 444);
            //--------------------




            //tmr = new System.Windows.Forms.Timer();
            //tmr.Tick += delegate
            //{
            //    this.Hide();
            //};
            //tmr.Interval = (int)TimeSpan.FromMinutes(0.1).TotalMilliseconds;
            //tmr.Start();

            //System.Threading.Thread.Sleep(5000);
            //countdownTimer();
            //goToLogin()

        }

 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
