using Library.DAOs;
using Library.ENUMs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public static class Methods
    {
        public static bool Message(string message, MessageTypeENUM type)
        {
            if (type == MessageTypeENUM.alert)
                MessageBox.Show(message, "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (type == MessageTypeENUM.error)
                MessageBox.Show(message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (type == MessageTypeENUM.information)
                MessageBox.Show(message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (type == MessageTypeENUM.question)
            {
                if (MessageBox.Show(message, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return true;
            }

            return false;
        }

        public static bool IntValidation(string value)
        {
            int convertedValue;
            return int.TryParse(value, out convertedValue);
        }

        public static bool DoubleValidation(string value)
        {
            double convertedValue;
            return double.TryParse(value, out convertedValue);
        }

        public static bool DataValidation(string value)
        {
            DateTime convertedValue;
            return DateTime.TryParse(value, out convertedValue);
        }


        public static void SQLExecuteNonQuery(string commandString, SqlParameter[] parameters)
        {
            using (SqlConnection connection = ConnectionDB.GetConnection(GlobalVariables.catalogDB, GlobalVariables.userIdDB, GlobalVariables.passwordDB))
            {
                using (SqlCommand command = new SqlCommand(commandString, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable SQLExecuteSelect(string commandString, SqlParameter[] parameters)
        {
            using (SqlConnection connection = ConnectionDB.GetConnection(GlobalVariables.catalogDB, GlobalVariables.userIdDB, GlobalVariables.passwordDB))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(commandString, connection))
                {
                    if (parameters != null)
                        adapter.SelectCommand.Parameters.AddRange(parameters);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
        }
    }
}
