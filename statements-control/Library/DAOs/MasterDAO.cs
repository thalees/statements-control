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

        protected abstract void SQLInsert(MasterVO vo);
        protected abstract void SQLUpdate(MasterVO vo);
        protected abstract void SQLDelete(int primaryKey);
        protected abstract DataTable SQLSearch(MasterVO vo);

        protected abstract MasterVO SQLFirst();
        protected abstract MasterVO SQLLast();
        protected abstract MasterVO SQLNext(int primaryKey);
        protected abstract MasterVO SQLPrevious(int primaryKey);

        protected abstract SqlParameter[] CreateParameters(MasterVO vo);
        protected abstract MasterVO BiuldVO(DataRow row);

        protected abstract MasterVO ObjectOrNull(DataTable table);
    }

}
