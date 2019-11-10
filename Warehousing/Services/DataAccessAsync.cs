using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Warehousing.Services
{
    class DataAccessAsync
    {
        public static async Task<DataTable> ExecSPAsync(string spName, List<SqlParameter> sqlParams = null)
        {
            if (sqlParams == null)
                sqlParams = new List<SqlParameter>();

            SqlConnection conn = new SqlConnection();
            DataTable dt = new DataTable();
            try
            {
                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Warehousing.Properties.Settings.DatabaseConnectionString"].ConnectionString;
                conn.Open();
                // bild an sql /qu
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParams.ToArray());
                //exec command
                SqlCommand command = conn.CreateCommand();
                SqlDataReader dr = await cmd.ExecuteReaderAsync();
                //fil datatable 
                dt.Load(dr);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در پایگاه داده ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
