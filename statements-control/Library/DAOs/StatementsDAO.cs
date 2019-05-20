using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.VOs;

namespace Library.DAOs
{
    class StatementsDAO : MasterDAO
    {
        protected override MasterVO BiuldVO(DataRow row)
        {
            StatementsVO statement = new StatementsVO();

            statement.Id = Convert.ToInt32(row["id"]);
            statement.UserId = Convert.ToInt32(row["userId"]);
            statement.TypeId = Convert.ToInt32(row["typeId"]);
            statement.EnvironmentId = Convert.ToInt32(row["environmentId"]);
            statement.Value = Convert.ToDouble(row["value"]);
            statement.Date = Convert.ToDateTime(row["date"]);

            return statement;
        }
        protected override SqlParameter[] CreateParameters(MasterVO vo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("id",(vo as StatementsVO).Id),
                new SqlParameter("userId", (vo as StatementsVO).UserId),
                new SqlParameter("typeId", (vo as StatementsVO).TypeId),
                new SqlParameter("environmentId", (vo as StatementsVO).EnvironmentId),
                new SqlParameter("value", (vo as StatementsVO).Value),
                new SqlParameter("date", (vo as StatementsVO).Date),
            };

            return parameters;
        }
        protected override MasterVO ObjectOrNull(DataTable table)
        {
            if (table.Rows.Count == 0)
                return null;
            else
                return BiuldVO(table.Rows[0]);
        }



        protected override void SQLInsert(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_InsertStatement", CreateParameters(vo));
        }
        protected override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateStatement", CreateParameters(vo));
        }
        protected override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteStatement", parameter);
        }


        protected override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstStatement", null);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastStatement", null);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextStatement", parameter);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousStatement", parameter);
            return ObjectOrNull(table);
        }

        protected override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as StatementsVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as StatementsVO).Id));
            else
                parameters.Add(new SqlParameter("@id", DBNull.Value));

            if ((vo as StatementsVO).UserId > 0)
                parameters.Add(new SqlParameter("@userId", (vo as StatementsVO).UserId));
            else
                parameters.Add(new SqlParameter("@userId", DBNull.Value));

            if ((vo as StatementsVO).TypeId > 0)
                parameters.Add(new SqlParameter("@typeId", (vo as StatementsVO).TypeId));
            else
                parameters.Add(new SqlParameter("@TypeId", DBNull.Value));

            if ((vo as StatementsVO).EnvironmentId > 0)
                parameters.Add(new SqlParameter("@environmentId", (vo as StatementsVO).EnvironmentId));
            else
                parameters.Add(new SqlParameter("@environmentId", DBNull.Value));

            if ((vo as StatementsVO).Value > 0)
                parameters.Add(new SqlParameter("@value", (vo as StatementsVO).Value));
            else
                parameters.Add(new SqlParameter("@value", DBNull.Value));

            if ((vo as StatementsVO).Date > DateTime.Now)
                parameters.Add(new SqlParameter("@date", (vo as StatementsVO).Date));
            else
                parameters.Add(new SqlParameter("@date", DBNull.Value));


            return Methods.SQLExecuteSelect("usp_SearchStatement", parameters.ToArray());
        }
    }
}
