using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QD_Reader
{
    class databaseLayer
    {
        private string connectionString="";
        public databaseLayer(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public int saveDataToDB(string awb, string courier, string[] job, string store, string note,string loggedInUser)
        {
            //string connetionString = null;
            SqlConnection con;
            //connetionString = "Data Source=DESKTOP-UUDJSE9;Initial Catalog=TestDb;Integrated Security=SSPI;";
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                int k = 0;
                //MessageBox.Show("Connection Open ! ");
                foreach (string s in job)
                {
                    if(s=="")
                    {
                        continue;
                    }
                    SqlCommand cmd = new SqlCommand("sp_saveDataToParcelReceiving", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("awb", awb);
                    cmd.Parameters.AddWithValue("courier", courier);
                    cmd.Parameters.AddWithValue("job", s);
                    cmd.Parameters.AddWithValue("store", store);
                    cmd.Parameters.AddWithValue("note", note);
                    cmd.Parameters.AddWithValue("lastUpdatedUser", loggedInUser);
                    k = cmd.ExecuteNonQuery();
                    
                }
                con.Close();
                return k;
            }
            catch (Exception ex)
            {
                //errorMsg.Text = "Can not open connection ! "
                LogWriter l = new LogWriter(ex.Message);
                return 0;
            }
        }
        public SqlDataAdapter getDataByAwb(string awb)
        {
            SqlConnection con;
            //connetionString = "Data Source=DESKTOP-UUDJSE9;Initial Catalog=TestDb;Integrated Security=SSPI;";
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                //MessageBox.Show("Connection Open ! ");
                var dataAdapter = new SqlDataAdapter("select * from ParcelReceiving where AirWayBill like '%" + awb + "%';", con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);


                con.Close();
                return dataAdapter;
            }
            catch (Exception ex)
            {
                //errorMsg.Text = "Can not open connection ! "
                return new SqlDataAdapter();
            }
        }
    }
}
