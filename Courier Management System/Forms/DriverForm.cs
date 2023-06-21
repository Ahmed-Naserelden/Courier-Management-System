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
using Oracle.DataAccess.Types;

namespace Courier_Management_System
{
    public partial class DriverForm : Form
    {

        //design

        private System.Windows.Forms.Button currentButton;
        public Random random;
        private int tempIndex;
        private Form activeForm;


        private Color SelectThemeColor()
        {

            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (System.Windows.Forms.Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (System.Windows.Forms.Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }


        private void DisableButton()
        {
            foreach (Control previousBtn in admin_panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(System.Windows.Forms.Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }


        //----------------------------------------------------------------------------------------------------



        string ordb = "Data Source = ORCL;  User Id = scott; Password = tiger;";
        OracleConnection conn;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public DriverForm()
        {
            //design
            random = new Random();
            //--------------
            InitializeComponent();
        }


        private void goToLoginForm()
        {
            LoginForm home = new LoginForm();
            home.Tag = this;
            home.Show(this);
            home.StartPosition = FormStartPosition.Manual;
            home.Location = this.Location;
            this.Hide();
        }

        private void ViewAllOrders_click(object sender, EventArgs e)
        {
            //design
            OpenChildForm(new Forms.DataGridViewForm_driver_(), sender);
            //-------------
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = conn;

            //cmd.CommandText = "view_all_requests";
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);


            //OracleDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dataGridView2.DataSource = dt;
        }

        //private void goToDriverAccountFormForm()
        //{
        //    DriverAccountInfoForm home = new DriverAccountInfoForm();
        //    home.Tag = this;
        //    home.Show(this);
        //    home.StartPosition = FormStartPosition.Manual;
        //    home.Location = this.Location;
        //    this.Hide();
        //}
        private void ViewAccountInfo_click(object sender, EventArgs e)
        {
            //design 
            OpenChildForm(new DriverAccountInfoForm(), sender);
            //ActivateButton(sender);
            //-------------
            //goToDriverAccountFormForm();
        }

        private void ResignationRequest_click(object sender, EventArgs e)
        {
            //design
            ActivateButton(sender);
            //-------------
            if (MessageBox.Show("Confirm resignation request:", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                OracleCommand c = new OracleCommand();
                c.Connection = conn;

                c.CommandText = "Delete from Drivers where D_EMAIL=:e";
                c.Parameters.Add("e", LoginForm.current_user);


                try
                {
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Actor deleted");
                        goToLoginForm();

                    }
                }
                catch
                {
                    MessageBox.Show("your Resignation Rejected");
                }
            }
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {

            this.MinimumSize = new Size(1195, 666);
            this.MaximumSize = new Size(1195, 666);


            label2.Text = LoginForm.current_user;
            conn = new OracleConnection(ordb);
            conn.Open();

            
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

        private void label3_Click(object sender, EventArgs e)
        {
            //design
            ActivateButton(sender);
            //-------------
            goOut();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void admin_panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DriverHome(), sender);
        }

        private void DesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
