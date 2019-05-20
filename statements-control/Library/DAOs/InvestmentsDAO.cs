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
    class InvestmentsDAO : MasterDAO
    {
        protected override MasterVO BiuldVO(DataRow row)
        {
            InvestmentsVO investment = new InvestmentsVO();

            investment.Id = Convert.ToInt32(row["id"]);
            investment.UserId = Convert.ToInt32(row["userId"]);
            investment.Value = Convert.ToDouble(row["value"]);
            investment.StartDate = Convert.ToDateTime(row["start"]);
            investment.EndDate = Convert.ToDateTime(row["end"]);

            return investment;
        }
        protected override SqlParameter[] CreateParameters(MasterVO vo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("id",(vo as InvestmentsVO).Id),
                new SqlParameter("userId", (vo as InvestmentsVO).UserId),
                new SqlParameter("value", (vo as InvestmentsVO).Value),
                new SqlParameter("start", (vo as InvestmentsVO).StartDate),
                new SqlParameter("end", (vo as InvestmentsVO).EndDate),
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
            Methods.SQLNonQueryProcedure("usp_InsertInvestment", CreateParameters(vo));
        }
        protected override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateInvestment", CreateParameters(vo));
        }
        protected override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteInvestment", parameter);
        }


        protected override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstInvestment", null);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastInvestment", null);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextInvestment", parameter);
            return ObjectOrNull(table);
        }
        protected override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousInvestment", parameter);
            return ObjectOrNull(table);
        }

        protected override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as InvestmentsVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as InvestmentsVO).Id));
            else
                parameters.Add(new SqlParameter("@id", DBNull.Value));

            if ((vo as InvestmentsVO).UserId > 0)
                parameters.Add(new SqlParameter("@userId", (vo as InvestmentsVO).UserId));
            else
                parameters.Add(new SqlParameter("@userId", DBNull.Value));

            if ((vo as InvestmentsVO).Value > 0)
                parameters.Add(new SqlParameter("@value", (vo as InvestmentsVO).Value));
            else
                parameters.Add(new SqlParameter("@value", DBNull.Value));

            if ((vo as InvestmentsVO).StartDate > DateTime.Now)
                parameters.Add(new SqlParameter("@start", (vo as InvestmentsVO).StartDate));
            else
                parameters.Add(new SqlParameter("@start", DBNull.Value));

            if ((vo as InvestmentsVO).EndDate < DateTime.Now)
                parameters.Add(new SqlParameter("@end", (vo as InvestmentsVO).EndDate));
            else
                parameters.Add(new SqlParameter("@end", DBNull.Value));


            return Methods.SQLExecuteSelect("usp_SearchInvestment", parameters.ToArray());
        }
    }
}
