using Library.ENUMs;
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

        public abstract void SQLInsert(MasterVO vo);
        public abstract void SQLUpdate(MasterVO vo);
        public abstract void SQLDelete(int primaryKey);
        public abstract DataTable SQLSearch(MasterVO vo);

        public abstract MasterVO SQLFirst();
        public abstract MasterVO SQLLast();
        public abstract MasterVO SQLNext(int primaryKey);
        public abstract MasterVO SQLPrevious(int primaryKey);

        public abstract SqlParameter[] CreateParameters(MasterVO vo, ActionDatabaseENUM action);
        public abstract MasterVO BiuldVO(DataRow row);

        public abstract MasterVO ObjectOrNull(DataTable table);
    }

}
