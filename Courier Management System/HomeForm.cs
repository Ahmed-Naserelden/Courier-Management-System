using Courier_Management_System.Models;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Courier_Management_System
{
    public partial class HomeForm : Form
    {
        DataSet ds;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            label1.Text = AccountInfo.user.Name;
            string cmdstr = "select DELIVERY_ID from deliveries where c_email =:email";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", AccountInfo.user.Email);


            ds = new DataSet();

            adapter.Fill(ds);

            dataGridView1.DataSource= ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // to void error
                if (dataGridView1.SelectedRows.Count > 1) 
                    break;

                
                string delvID = row.Cells[0].Value.ToString();


                string cmdstr = "SELECT D_EMAIL, DESTINATOIN_ADDRESS, SOURCE_ADDRESS, PAKAGE_SIZE, STATUS from deliveries where DELIVERY_ID =:ID";

                adapter = new OracleDataAdapter(cmdstr, ordb);
                adapter.SelectCommand.Parameters.Add("ID", delvID);

                DataSet das = new DataSet();

                adapter.Fill(das);

                dataGridView2.DataSource = das.Tables[0];
                
            }

        }
    }

}
