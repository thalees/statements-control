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

        //protected string table { get; set; }
        //protected string key { get; set; } = "id";

        protected abstract string SQLInsert();
        protected abstract string SQLUpdate();
        protected abstract string SQLDelete();
        protected abstract string SQLSearch();

        protected abstract string SQLFirst();
        protected abstract string SQLLast();
        protected abstract string SQLNext();
        protected abstract string SQLPrevious();

        protected abstract SqlParameter[] CreateParameters(MasterVO vo);
        protected abstract MasterVO BiuldVO(DataRow row);
    }

}
