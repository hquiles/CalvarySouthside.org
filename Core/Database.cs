using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Infrastructure
{
    public static class Database
    {
        #region Properties

        private static string connectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
        }

        #endregion

        #region Methods

        public static DataSet ExecuteStoredProcedure(string proc, params SqlParameter[] sqlParams)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();

            try
            {
                // prepare command
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = proc;

                foreach (SqlParameter sqlParam in sqlParams)
                    cmd.Parameters.Add(sqlParam);

                // open connection
                conn.Open();

                // fill dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch(Exception e)
            {
                // log exception
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return ds;
        }

        #endregion

    }
}
