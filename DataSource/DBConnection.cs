using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSource
{
    class DBConnection
    {
        public static SqlCommand CreateCommand()
        {
            SqlCommand cmd = null;

            try
            {

                string s = @"Data Source=DESKTOP-ET98443\SQLEXPRESS;Initial Catalog=CompanyHolidays;Integrated Security=True";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = s;
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

            return cmd;
        }

        public static DataTable DisplayHoliday()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = CreateCommand();
                cmd.CommandText = "usp_Display_Holidays";

                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                cmd.Connection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (SystemException ex)
            {
                throw ex;
            }

            return dt;
        }
        static void Main(string[] args)
        {

        }
    }
}
