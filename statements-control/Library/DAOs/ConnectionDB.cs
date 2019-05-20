using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    public static class ConnectionDB
    {
        public static SqlConnection GetConnection(string catalog, string userId, string password)
        {
            string connectionString = $"Data Source=LOCALHOST; Initial Catalog ={catalog}; user id={userId}; password={password}";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
