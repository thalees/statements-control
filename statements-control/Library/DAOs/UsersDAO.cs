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
        public override SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action)
        {
            if (action == ActionDatabaseENUM.insert)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@name", (vo as UsersVO).Name),
                    new SqlParameter("@picture", (vo as UsersVO).Picture),
                    new SqlParameter("@dateBirth", (vo as UsersVO).DateBirth),
                    new SqlParameter("@password", (vo as UsersVO).Password),
                };
                return parameters;
            }
            else if (action == ActionDatabaseENUM.update)
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@id", (vo as UsersVO).Id),
                    new SqlParameter("@name", (vo as UsersVO).Name),
                    new SqlParameter("@picture", (vo as UsersVO).Picture),
                    new SqlParameter("@dateBirth", (vo as UsersVO).DateBirth),
                    new SqlParameter("@password", (vo as UsersVO).Password),
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
            Methods.SQLNonQueryProcedure("usp_InsertUser", CreateParameters(vo, ActionDatabaseENUM.insert));
        }
        public override void SQLUpdate(MasterVO vo)
        {
            Methods.SQLNonQueryProcedure("usp_UpdateUser", CreateParameters(vo, ActionDatabaseENUM.update));
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

            if (!string.IsNullOrEmpty((vo as UsersVO).Name))
                parameters.Add(new SqlParameter("@name", (vo as UsersVO).Name));


            if ((vo as UsersVO).Picture.Length > 0)
                parameters.Add(new SqlParameter("@picture", (vo as UsersVO).Picture));

            if ((vo as UsersVO).DateBirth < DateTime.Now)
                parameters.Add(new SqlParameter("@dtBirth", (vo as UsersVO).DateBirth));

            if (!string.IsNullOrEmpty((vo as UsersVO).Password))
                parameters.Add(new SqlParameter("@password", (vo as UsersVO).Password));


            return Methods.SQLSelectProcedure("usp_FilterUsersByName", parameters.ToArray());
        }
    }
}
