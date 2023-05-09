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
    public partial class CustomerFrom : Form
    {


        //design

        private System.Windows.Forms.Button currentButton;
        private Random random;
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



        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";

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
        public CustomerFrom()
        {
            //design
            random = new Random();
            //--------------
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
            
        }


        private void WriteAcomplaint_click(object sender, EventArgs e)
        {
            //design
            OpenChildForm(new MakeComplainmentForm(), sender);
            //-------------
            //goToComplainmentForm();
        }

        private void Book_Arequest_click(object sender, EventArgs e)
        {
            //design
            OpenChildForm(new MakeOrderForm(), sender);
            //-------------
            //goToMakeOrderForm();

        }

        private void ViewMyOrders_click(object sender, EventArgs e)
        {
            //design
            //ActivateButton(sender);
            OpenChildForm(new Forms.DataGridViewForm_customer_(), sender);
            //-------------
            //string cmdstr = "select DELIVERY_ID , C_EMAIL, SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE from deliveries where c_email =:email";
            //adapter = new OracleDataAdapter(cmdstr, ordb);
            //adapter.SelectCommand.Parameters.Add("email", CustomerAccountInfo.user.Email);
            //ds = new DataSet();
            //adapter.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }


        private void label2_Click(object sender, EventArgs e)
        {
            //design
            ActivateButton(sender);
            //-------------
            goOut();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewAccinfo_Click(object sender, EventArgs e)
        {
            //design
            //ActivateButton(sender);
            OpenChildForm(new AccountForm(), sender);
            //-------------
            //goToAccountForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CustomerHome(), sender);
        }

        private void view_acc_info_click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountForm(), sender) ;
        }
    }

}