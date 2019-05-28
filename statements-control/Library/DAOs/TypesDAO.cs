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
    public class TypesDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            TypesVO type = new TypesVO();

            type.Id = Convert.ToInt32(row["id"]);
            type.Name = row["name"].ToString();
            type.Description = row["description"].ToString();
            type.Action = row["action"].ToString();

            return type;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action)
        {
            if (action == ActionDatabaseENUM.insert)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", (vo as TypesVO).Name),
                    new SqlParameter("@description", (vo as TypesVO).Description),
                    new SqlParameter("@action", (vo as TypesVO).Action)
                };
                return parameters;
            }
            else if (action == ActionDatabaseENUM.update)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@id",(vo as TypesVO).Id),
                    new SqlParameter("@name", (vo as TypesVO).Name),
                    new SqlParameter("@description", (vo as TypesVO).Description),
                    new SqlParameter("@action", (vo as TypesVO).Action)
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
            Methods.SQLNonQueryProcedure("usp_InsertType", CreateParameters(vo, ActionDatabaseENUM.insert));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateType", CreateParameters(vo, ActionDatabaseENUM.update));
        }
        public override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteType", parameter);
        }


        public override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstType", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastType", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextType", parameter);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousType", parameter);
            return ObjectOrNull(table);
        }


        public override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as TypesVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as TypesVO).Id));
            else
                parameters.Add(new SqlParameter("@id", DBNull.Value));

            if (!string.IsNullOrEmpty((vo as TypesVO).Description))
                parameters.Add(new SqlParameter("@description", (vo as TypesVO).Description));
            else
                parameters.Add(new SqlParameter("@description", DBNull.Value));

            if (!string.IsNullOrEmpty((vo as TypesVO).Action))
                parameters.Add(new SqlParameter("@action", (vo as TypesVO).Action));
            else
                parameters.Add(new SqlParameter("@action", DBNull.Value));

            return Methods.SQLExecuteSelect("usp_SearchType", parameters.ToArray());
        }

        public List<TypesVO> List(string name)
        {
            SqlParameter[] parameter = { new SqlParameter("@name", name) };
            DataTable table = Methods.SQLSelectProcedure("usp_FilterTypesByName", parameter);

            List<TypesVO> list = new List<TypesVO>();
            foreach (DataRow row in table.Rows)
            {
                list.Add(BiuldVO(row) as TypesVO);
            }
            return list;
        }
    }
}
