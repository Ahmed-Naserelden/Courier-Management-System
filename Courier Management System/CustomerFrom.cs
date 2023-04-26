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
    public partial class CustomerFrom : Form
    {
        DataSet ds, ds2;
        OracleDataAdapter adapter, adapter2;
        OracleCommandBuilder builder, builder2;
        string ordb = "Data Source=ORCL; User Id= scott; Password=tiger;";

        public CustomerFrom()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            label1.Text = AccountInfo.user.Name;
            string cmdstr = "select DELIVERY_ID, C_EMAIL, SOURCE_ADDRESS, DESTINATOIN_ADDRESS, PAKAGE_SIZE from deliveries where c_email =:email";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            adapter.SelectCommand.Parameters.Add("email", AccountInfo.user.Email);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
           // builder2 = new OracleCommandBuilder(adapter2);

            adapter.Update(ds.Tables[0]);
            //adapter2.Update(ds2.Tables[0]);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    // to void error
            //    if (dataGridView1.SelectedRows.Count > 1) 
            //        break;

                
            //    string delvID = row.Cells[0].Value.ToString();
            //    string cmdstr = "SELECT D_EMAIL, DESTINATOIN_ADDRESS, SOURCE_ADDRESS, PAKAGE_SIZE, STATUS, PROCESSDATE from deliveries where DELIVERY_ID =:ID";

            //    adapter2 = new OracleDataAdapter(cmdstr, ordb);
            //    adapter2.SelectCommand.Parameters.Add("ID", delvID);

            //    DataSet ds2 = new DataSet();
            //    adapter.Fill(ds2);

            //    dataGridView2.DataSource = ds2.Tables[0];
                
            //}

        }
    }

}
