using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QD_Reader
{
    public partial class settingFrm : Form
    {
        string connectionString;
        public settingFrm(string con)
        {
            connectionString = con;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string awb = txtAwb.Text;
                if (awb.Trim() == "")
                {
                    MessageBox.Show("Please enter AWB#");
                    return;
                }
                databaseLayer ddl = new databaseLayer(connectionString);
                SqlDataAdapter dataAdapter = ddl.getDataByAwb(awb);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("No data to show");
            }
        }
    }
}
