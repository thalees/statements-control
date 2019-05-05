using Library.DAOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Methods
    {
        public static bool IntValidation(string valor)
        {
            int convertedValue;
            return int.TryParse(valor, out convertedValue);
        }

        public static bool DoubleValidation(string valor)
        {
            double convertedValue;
            return double.TryParse(valor, out convertedValue);
        }

        public static bool DataValidation(string data)
        {
            DateTime convertedValue;
            return DateTime.TryParse(data, out convertedValue);
        }

        public static void SQLNonQueryCommand(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection connection = ConnectionDB.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SQLSelectCommand(string sql, SqlParameter[] parametros)
        {
            using (SqlConnection connection = ConnectionDB.GetConexao())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    if (parametros != null)
                        adapter.SelectCommand.Parameters.AddRange(parametros);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
