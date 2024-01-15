using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Shop
{
    public class DatabaseHelper
    {
        private string _connectionString = "Data Source=DESKTOP-UD85H0H\\MSSQLVIWATH;Initial Catalog=vshop;Persist Security Info=True;User ID=sa;Password=viwath@261102";

        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        private void CloseConnection(SqlConnection connection)
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using(SqlConnection conn = OpenConnection())
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public SqlDataReader ExecuteReader(string query)
        {
            SqlConnection conn = OpenConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        
    }
}
