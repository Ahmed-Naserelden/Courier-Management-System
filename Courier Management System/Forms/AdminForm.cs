using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Courier_Management_System.Models;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Courier_Management_System
{
    public partial class AdminForm : Form
    {


        //design

        private Button currentButton;
        private Random random;
        private int tempIndex;

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
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
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
                if (previousBtn.GetType() == typeof(Button))
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

        public AdminForm()
        {
            InitializeComponent();
            //design
            random = new Random();
            //--------------
        }

        private void ViewCustomers_Click(object sender, EventArgs e)
        {
            //design
            ActivateButton(sender);
            //-------------

            updatebtn.Visible = false;
            search.Visible = false;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "viewCustInfo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);


            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }


        private void viewDriver_Click(object sender, EventArgs e)
        {
            //design
            ActivateButton(sender);
            //-------------

            updatebtn.Visible = false;
            search.Visible = false;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "viewDriverInfo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            label1.Text = LoginForm.current_user;

        }

        private void viewOrder_Click(object sender, EventArgs e)
        {
            //design
            ActivateButton(sender);
            //-------------

            updatebtn.Visible = false;
            search.Visible = false;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "view_all_requests";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("row", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

        }
        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;

        private void complain_Click(object sender, EventArgs e)
        {

            //design
            ActivateButton(sender);
            //-------------
            updatebtn.Visible = true;
            search.Visible = true;

            
            string cmdstr = "SELECT * FROM COMPLAINS WHERE status =:stat";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("status", "0");
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }


        private void updatebtn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cmdstr = "SELECT * FROM COMPLAINS WHERE C_EMAIL =:email";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", search.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void showCrystalReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}