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
    class GoalsDAO : MasterDAO
    {
        protected override MasterVO BiuldVO(DataRow row)
        {
            GoalsVO goal = new GoalsVO  ();

            goal.Id = Convert.ToInt32(row["id"]);
            goal.UserId = Convert.ToInt32(row["userId"]);
            goal.Name = (row["name"]).ToString();
            goal.EndDate = Convert.ToDateTime(row["endDate"]);

            return goal;
        }
        protected override SqlParameter[] CreateParameters(MasterVO vo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("id",(vo as GoalsVO).Id),
                new SqlParameter("name", (vo as GoalsVO).Name),
                new SqlParameter("userId", (vo as GoalsVO).UserId),
                new SqlParameter("endDate", (vo as GoalsVO).EndDate),
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
            Methods.SQLNonQueryProcedure("usp_InsertGoal", CreateParameters(vo));
        }
        protected override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateGoal", CreateParameters(vo));
        }
        protected override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteGoal", parameter);
        }


        protected override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstGoal", null);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastGoal", null);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextGoal", parameter);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousGoal", parameter);
            return ObjectOrNull(table);
        }

        protected override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as GoalsVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as GoalsVO).Id));
            else
                parameters.Add(new SqlParameter("@id", DBNull.Value));

            if ((vo as GoalsVO).UserId > 0)
                parameters.Add(new SqlParameter("@userId", (vo as GoalsVO).UserId));
            else
                parameters.Add(new SqlParameter("@userId", DBNull.Value));

            if (!string.IsNullOrEmpty((vo as GoalsVO).Name))
                parameters.Add(new SqlParameter("@typeId", (vo as GoalsVO).Name));
            else
                parameters.Add(new SqlParameter("@TypeId", DBNull.Value));

            if ((vo as GoalsVO).EndDate < DateTime.Now)
                parameters.Add(new SqlParameter("@date", (vo as GoalsVO).EndDate));
            else
                parameters.Add(new SqlParameter("@date", DBNull.Value));


            return Methods.SQLExecuteSelect("usp_SearchGoal", parameters.ToArray());
        }
    }
}
