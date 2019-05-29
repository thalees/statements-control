using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.ENUMs;
using Library.VOs;

namespace Library.DAOs
{
    public class StatementsDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            StatementsVO statement = new StatementsVO();

            statement.Id = Convert.ToInt32(row["id"]);
            statement.Name = row["name"].ToString();
            statement.UserId = Convert.ToInt32(row["userId"]);
            statement.TypeId = Convert.ToInt32(row["typeId"]);
            statement.EnvironmentId = Convert.ToInt32(row["environmentId"]);
            statement.Value = Convert.ToDouble(row["value"]);
            statement.Date = Convert.ToDateTime(row["date"]);

            return statement;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action)
        {
            if (action == ActionDatabaseENUM.insert)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name",(vo as StatementsVO).Name),
                    new SqlParameter("@userId", (vo as StatementsVO).UserId),
                    new SqlParameter("@typeId", (vo as StatementsVO).TypeId),
                    new SqlParameter("@environmentId", (vo as StatementsVO).EnvironmentId),
                    new SqlParameter("@value", (vo as StatementsVO).Value),
                    new SqlParameter("@date", (vo as StatementsVO).Date),
                };
                return parameters;
            }
            else if (action == ActionDatabaseENUM.update)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@id",(vo as StatementsVO).Id),
                    new SqlParameter("@name",(vo as StatementsVO).Name),
                    new SqlParameter("@userId", (vo as StatementsVO).UserId),
                    new SqlParameter("@typeId", (vo as StatementsVO).TypeId),
                    new SqlParameter("@environmentId", (vo as StatementsVO).EnvironmentId),
                    new SqlParameter("@value", (vo as StatementsVO).Value),
                    new SqlParameter("@date", (vo as StatementsVO).Date),
                };
                return parameters;
            }
            else
                throw new Exception("Escolha um método válido para executar.");
        }


        public override MasterVO ObjectOrNull(DataTable table)
        {
            if (table.Rows.Count == 0)
                return null;
            else
                return BiuldVO(table.Rows[0]);
        }


        public override void SQLInsert(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_InsertStatement", CreateParameters(vo, ActionDatabaseENUM.insert));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateStatement", CreateParameters(vo, ActionDatabaseENUM.update));
        }
        public override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteStatement", parameter);
        }


        public override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstStatement", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastStatement", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextStatement", parameter);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousStatement", parameter);
            return ObjectOrNull(table);
        }

        public override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as StatementsVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as StatementsVO).Id));

            if (!string.IsNullOrEmpty((vo as StatementsVO).Name))
                parameters.Add(new SqlParameter("@name", (vo as StatementsVO).Name));

            if ((vo as StatementsVO).UserId > 0)
                parameters.Add(new SqlParameter("@userId", (vo as StatementsVO).UserId));

            if ((vo as StatementsVO).TypeId > 0)
                parameters.Add(new SqlParameter("@typeId", (vo as StatementsVO).TypeId));

            if ((vo as StatementsVO).EnvironmentId > 0)
                parameters.Add(new SqlParameter("@environmentId", (vo as StatementsVO).EnvironmentId));

            if ((vo as StatementsVO).Value > 0)
                parameters.Add(new SqlParameter("@value", (vo as StatementsVO).Value));

            if ((vo as StatementsVO).Date > DateTime.Now)
                parameters.Add(new SqlParameter("@date", (vo as StatementsVO).Date));


            return Methods.SQLSelectProcedure("usp_FilterStatementsByName", parameters.ToArray());
        }
    }
}
