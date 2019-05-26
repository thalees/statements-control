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
    public class EnvironmentsDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            EnvironmentsVO environment = new EnvironmentsVO();
            environment.Id = Convert.ToInt32(row["id"]);
            environment.Name = row["name"].ToString();
            return environment;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("id",(vo as EnvironmentsVO).Id),
                new SqlParameter("name", (vo as EnvironmentsVO).Name),
            };

            return parameters;
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
            Methods.SQLNonQueryProcedure("usp_InsertEnvironment", CreateParameters(vo));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateEnvironment", CreateParameters(vo));
        }
        public override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteEnvironment", parameter);
        }


        public override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstEnvironment", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastEnvironment", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextEnvironment", parameter);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousEnvironment", parameter);
            return ObjectOrNull(table);
        }

        public override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as EnvironmentsVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as EnvironmentsVO).Id));
            else
                parameters.Add(new SqlParameter("@id", DBNull.Value));

            if(!string.IsNullOrEmpty((vo as EnvironmentsVO).Name))
                parameters.Add(new SqlParameter("@name", (vo as EnvironmentsVO).Name));
            else
                parameters.Add(new SqlParameter("@name", DBNull.Value));


            return Methods.SQLExecuteSelect("usp_SearchEnvironment", parameters.ToArray());
        }

        public List<EnvironmentsVO> List(string name)
        {
            SqlParameter[] parameter = { new SqlParameter("@name", name) };
            DataTable table = Methods.SQLSelectProcedure("usp_FilterEnvironmentsByName", parameter);

            List<EnvironmentsVO> list = new List<EnvironmentsVO>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(BiuldVO(row) as EnvironmentsVO);
            }
            return list;
        }
    }
}
