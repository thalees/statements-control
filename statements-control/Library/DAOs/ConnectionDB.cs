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
        private static string catalogDB;
        private static string userIdDB;
        private static string passwordDB;

        public static bool setCatalogDB(string parCatalogDB, Type formType)
        {
            if (formType.Name.ToString() == "fr_DataBaseParameters")
            {
                catalogDB = parCatalogDB;
                return true;
            }
            else
                return false;
        }
        public static bool setUsernameDB(string parUsernameDB, Type formType)
        {
            if (formType.Name.ToString() == "fr_DataBaseParameters")
            {
                userIdDB = parUsernameDB;
                return true;
            }
            else
                return false;
        }
        public static bool setPasswordDB(string parPassword, Type formType)
        {
            if (formType.Name.ToString() == "fr_DataBaseParameters")
            {
                passwordDB = parPassword;
                return true;
            }
            else
                return false;
        }

        public static SqlConnection GetConnection()
        {
            string connectionString = $"Data Source=LOCALHOST; Initial Catalog ={catalogDB}; user id={userIdDB}; password={passwordDB}";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
