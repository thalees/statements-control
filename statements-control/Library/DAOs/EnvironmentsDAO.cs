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
    public class EnvironmentsDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            EnvironmentsVO environment = new EnvironmentsVO();
            environment.Id = Convert.ToInt32(row["id"]);
            environment.Name = row["name"].ToString();
            environment.Description = row["description"].ToString();
            return environment;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action)
        {
            if (action == ActionDatabaseENUM.insert)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", (vo as EnvironmentsVO).Name),
                    new SqlParameter("@description", (vo as EnvironmentsVO).Description),
                };
                return parameters;
            }
            else if (action == ActionDatabaseENUM.update)
            {
                SqlParameter[] parameters = 
                {
                    new SqlParameter("@id",(vo as EnvironmentsVO).Id),
                    new SqlParameter("@name", (vo as EnvironmentsVO).Name),
                    new SqlParameter("@description", (vo as EnvironmentsVO).Description),
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
            Methods.SQLNonQueryProcedure("usp_InsertEnvironment", CreateParameters(vo, ActionDatabaseENUM.insert));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateEnvironment", CreateParameters(vo, ActionDatabaseENUM.update));
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

            if(!string.IsNullOrEmpty((vo as EnvironmentsVO).Name))
                parameters.Add(new SqlParameter("@name", (vo as EnvironmentsVO).Name));

            if (!string.IsNullOrEmpty((vo as EnvironmentsVO).Description))
                parameters.Add(new SqlParameter("@name", (vo as EnvironmentsVO).Description));

            return Methods.SQLSelectProcedure("usp_FilterEnvironmentsByName", parameters.ToArray());
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
