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
    public class UsersDAO : MasterDAO
    {
        public override MasterVO BiuldVO(DataRow row)
        {
            UsersVO user = new UsersVO();

            user.Id = Convert.ToInt32(row["id"]);
            user.Name = row["name"].ToString();
            user.Picture = (row["picture"] as byte[]);
            user.DateBirth = Convert.ToDateTime(row["dtBirth"]);
            user.Password = row["password"].ToString();

            return user;
        }
        public override SqlParameter[] CreateParameters(MasterVO vo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("id",(vo as UsersVO).Id),
                new SqlParameter("name", (vo as UsersVO).Name),
                new SqlParameter("picture", (vo as UsersVO).Picture),
                new SqlParameter("dtBirth", (vo as UsersVO).DateBirth),
                new SqlParameter("password", (vo as UsersVO).Password),
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
            Methods.SQLNonQueryProcedure("usp_InsertUser", CreateParameters(vo));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateUser", CreateParameters(vo));
        }
        public override void SQLDelete(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("id", primaryKey) };
            Methods.SQLNonQueryProcedure("usp_DeleteUser", parameter);
        }


        public override MasterVO SQLFirst()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_FirstUser", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLLast()
        {
            DataTable table = Methods.SQLSelectProcedure("usp_LastUser", null);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLNext(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_NextUser", parameter);
            return ObjectOrNull(table);
        }
        public override MasterVO SQLPrevious(int primaryKey)
        {
            SqlParameter[] parameter = { new SqlParameter("@currentId", primaryKey) };
            DataTable table = Methods.SQLSelectProcedure("usp_PreviousUser", parameter);
            return ObjectOrNull(table);
        }

        public override DataTable SQLSearch(MasterVO vo)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            if ((vo as UsersVO).Id > 0)
                parameters.Add(new SqlParameter("@id", (vo as UsersVO).Id));
            else
                parameters.Add(new SqlParameter("@id", DBNull.Value));

            if (string.IsNullOrEmpty((vo as UsersVO).Name))
                parameters.Add(new SqlParameter("@name", (vo as UsersVO).Name));
            else
                parameters.Add(new SqlParameter("@name", DBNull.Value));

            if ((vo as UsersVO).Picture.Length > 0)
                parameters.Add(new SqlParameter("@picture", (vo as UsersVO).Picture));
            else
                parameters.Add(new SqlParameter("@picture", DBNull.Value));

            if ((vo as UsersVO).DateBirth > DateTime.Now)
                parameters.Add(new SqlParameter("@dtBirth", (vo as UsersVO).DateBirth));
            else
                parameters.Add(new SqlParameter("@dtbirth", DBNull.Value));

            if (!string.IsNullOrEmpty((vo as UsersVO).Password))
                parameters.Add(new SqlParameter("@password", (vo as UsersVO).Password));
            else
                parameters.Add(new SqlParameter("@password", DBNull.Value));

            return Methods.SQLExecuteSelect("usp_SearchUser", parameters.ToArray());
        }
    }
}
