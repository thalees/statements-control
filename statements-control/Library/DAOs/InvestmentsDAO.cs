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
    public class InvestmentsDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            InvestmentsVO investment = new InvestmentsVO();

            investment.Id = Convert.ToInt32(row["id"]);
            investment.Name = row["name"].ToString();
            investment.UserId = Convert.ToInt32(row["userId"]);
            investment.Value = Convert.ToDouble(row["value"]);
            investment.StartDate = Convert.ToDateTime(row["startDate"]);
            investment.EndDate = Convert.ToDateTime(row["endDate"]);

            return investment;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action)
        {
            if (action == ActionDatabaseENUM.insert)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", (vo as InvestmentsVO).Name),
                    new SqlParameter("@userId", (vo as InvestmentsVO).UserId),
                    new SqlParameter("@value", (vo as InvestmentsVO).Value),
                    new SqlParameter("@start", (vo as InvestmentsVO).StartDate),
                    new SqlParameter("@end", (vo as InvestmentsVO).EndDate),
                };
                return parameters;
            }
            else if (action == ActionDatabaseENUM.update)
            {
                SqlParameter[] parameters = 
                {
                    new SqlParameter("@id",(vo as InvestmentsVO).Id),
                    new SqlParameter("@name", (vo as InvestmentsVO).Name),
                    new SqlParameter("@userId", (vo as InvestmentsVO).UserId),
                    new SqlParameter("@value", (vo as InvestmentsVO).Value),
                    new SqlParameter("@start", (vo as InvestmentsVO).StartDate),
                    new SqlParameter("@end", (vo as InvestmentsVO).EndDate),
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
            Methods.SQLNonQueryProcedure("usp_InsertInvestment", CreateParameters(vo, ActionDatabaseENUM.insert));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateInvestment", CreateParameters(vo, ActionDatabaseENUM.update));
        }
        public override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteInvestment", parameter);
        }


        public override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstInvestment", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastInvestment", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextInvestment", parameter);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousInvestment", parameter);
            return ObjectOrNull(table);
        }

        public override DataTable SQLSearch(MasterVO vo)
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
