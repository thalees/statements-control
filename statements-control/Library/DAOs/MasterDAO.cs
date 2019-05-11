using Library.VOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAOs
{
    public abstract class MasterDAO
    {

        protected string table { get; set; }
        protected string key { get; set; } = "id"; // valor default
        protected abstract string MontaSQLInsert();
        protected abstract string MontaSQLUpdate();
        protected abstract SqlParameter[] CriaParametros(MasterVO o);
        protected abstract MasterVO MontaVO(DataRow dr);

        protected virtual string MontaSQLDelete()
        {
            return $"delete {table} where {key} = @id";
        }
        protected virtual string MontaSQLConsulta()
        {
            return $"select * from {table} where {key} = @id";
        }
        /// <summary>
        /// Método para inserir um registro no BD
        /// </summary>
        public virtual void Inserir(MasterVO o)
        {
            if (Consulta(o.Id) != null)
                throw new Exception("Este código já está sendo utilizado!");
            string sql = MontaSQLInsert();
            Methods.SQLExecuteNonQuery(sql, CriaParametros(o));
        }

        /// <summary>
        /// Método para alterar um regisstro
        /// </summary>
        public virtual void Alterar(MasterVO o)
        {
            string sql = MontaSQLUpdate();
            Methods.SQLExecuteNonQuery(sql, CriaParametros(o));
        }

        /// <summary>
        /// Método para excluir
        /// </summary>
        public virtual void Excluir(int Id)
        {
            string sql = MontaSQLDelete();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter(key, Id);
            Methods.SQLExecuteNonQuery(sql, parametros);
        }

        /// <summary>
        /// Método para consultar 1 registro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MasterVO Consulta(int id)
        {
            using (SqlConnection cx = ConnectionDB.GetConnection(GlobalVariables.catalogDB, GlobalVariables.userIdDB, GlobalVariables.passwordDB))
            {
                string sql = MontaSQLConsulta();
                SqlParameter[] parametros =
                {
                    new SqlParameter(key, id)
                };
                DataTable tabela = Methods.SQLExecuteSelect(sql, parametros);
                if (tabela.Rows.Count == 0)
                    return null;
                else
                {
                    return MontaVO(tabela.Rows[0]);
                }
            }
        }

        /// <summary>
        /// Obtem o Proximo id disponível
        /// </summary>
        /// <returns></returns>
        public virtual int ProximoId()
        {
            string sql = $"select isnull(max({key})+1,1) from {table}";
            using (SqlConnection cx = ConnectionDB.GetConnection(GlobalVariables.catalogDB, GlobalVariables.userIdDB, GlobalVariables.passwordDB))
            {
                SqlCommand cmd = new SqlCommand(sql, cx);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        /// <summary>
        /// Primeiro registro
        /// </summary>
        /// <returns></returns>
        public virtual MasterVO Primeiro()
        {
            string sql = $"select top 1 * from {table} order by {key}";
            return ExecutaSqlLocal(sql, null);
        }

        /// <summary>
        /// Ultimo registro
        /// </summary>
        /// <returns></returns>
        public virtual MasterVO Ultimo()
        {
            string sql = $"select top 1 * from {table} order by {key} desc";
            DataTable tabela = Methods.SQLExecuteSelect(sql, null);
            return ExecutaSqlLocal(sql, null);
        }

        /// <summary>
        /// Próximo registro
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual MasterVO Proximo(int atual)
        {
            string sql = $"select top 1 * from {table} where {key} > @Atual order by {key} ";
            SqlParameter[] p =
            {
                new SqlParameter("Atual", atual)
            };
            return ExecutaSqlLocal(sql, p);
        }

        /// <summary>
        /// Registro anterior
        /// </summary>
        /// <param name="atual"></param>
        /// <returns></returns>
        public virtual MasterVO Anterior(int atual)
        {
            string sql = $"select top 1 * from {table} where {key} < @Atual order by {key} desc";
            SqlParameter[] p =
            {
                new SqlParameter("Atual", atual)
            };
            return ExecutaSqlLocal(sql, p);
        }


        protected MasterVO ExecutaSqlLocal(string sql, SqlParameter[] parametros)
        {
            DataTable tabela = Methods.SQLExecuteSelect(sql, parametros);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaVO(tabela.Rows[0]);
        }
    }
}
