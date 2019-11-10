using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehousing.Services
{
    public static class DataAccess
    {
        public static DataTable ExecSP(string spName, List<SqlParameter> sqlParams = null)
        {
            //string strConnect = "Server=ALI-PC\\SQLSERVER2017;Database=Myloginapp;Trusted_Connection=True";
            //string strConnect = "Data Source=192.168.1.15,1443;Initial Catalog = Myloginapp; User ID = ALI; Password = ali6300";
            //string strConnect = "192.168.1.6,1443;Database=Myloginapp;Trusted_Connection=True";
            //string strConnect = "Server=2.182.221.56,1433;Database=Myloginapp; User ID =ALI; Password =ali6300";


            SqlConnection conn = new SqlConnection();
            DataTable dt = new DataTable();
            try
            {
                //connect to database
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["t1"].ConnectionString;
                //conn = new SqlConnection(strConnect);
                conn.Open();
                // bild an sql /qu
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParams.ToArray());
                //exec command
                SqlCommand command = conn.CreateCommand();
                SqlDataReader dr = cmd.ExecuteReader();

                //fil datatable 
                dt.Load(dr);


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "خطا در پایگاه داده ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw ex;
            }
            finally
            {
                //close 
                conn.Close();
            }
            return dt;
        }

    }
}
