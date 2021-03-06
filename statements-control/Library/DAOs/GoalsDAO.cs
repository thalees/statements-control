﻿using System;
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
    public class GoalsDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            GoalsVO goal = new GoalsVO  ();

            goal.Id = Convert.ToInt32(row["id"]);
            goal.UserId = Convert.ToInt32(row["userId"]);
            goal.Name = row["name"].ToString();
            goal.EndDate = Convert.ToDateTime(row["endDate"]);

            return goal;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action)
        {
            if (action == ActionDatabaseENUM.insert)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", (vo as GoalsVO).Name),
                    new SqlParameter("@userId", (vo as GoalsVO).UserId),
                    new SqlParameter("@endDate", (vo as GoalsVO).EndDate),
                };
                return parameters;
            }
            else if (action == ActionDatabaseENUM.update)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@id",(vo as GoalsVO).Id),
                    new SqlParameter("@name", (vo as GoalsVO).Name),
                    new SqlParameter("@userId", (vo as GoalsVO).UserId),
                    new SqlParameter("@endDate", (vo as GoalsVO).EndDate),
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
            Methods.SQLNonQueryProcedure("usp_InsertGoal", CreateParameters(vo, ActionDatabaseENUM.insert));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateGoal", CreateParameters(vo, ActionDatabaseENUM.update));
        }
        public override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteGoal", parameter);
        }


        public override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstGoal", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastGoal", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextGoal", parameter);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousGoal", parameter);
            return ObjectOrNull(table);
        }

        public override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as GoalsVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as GoalsVO).Id));

            if (!string.IsNullOrEmpty((vo as GoalsVO).Name))
                parameters.Add(new SqlParameter("@name", (vo as GoalsVO).Name));

            if ((vo as GoalsVO).UserId > 0)
                parameters.Add(new SqlParameter("@userId", (vo as GoalsVO).UserId));

            if (!string.IsNullOrEmpty((vo as GoalsVO).Name))
                parameters.Add(new SqlParameter("@typeId", (vo as GoalsVO).Name));

            if ((vo as GoalsVO).EndDate < DateTime.Now)
                parameters.Add(new SqlParameter("@date", (vo as GoalsVO).EndDate));


            return Methods.SQLSelectProcedure("fn_FilterGoalsByName", parameters.ToArray());
        }
    }
}
