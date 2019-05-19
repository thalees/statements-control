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
    class InvestmentsDAO : MasterDAO
    {
        protected override MasterVO BiuldVO(DataRow dr)
        {
            throw new NotImplementedException();
        }

        protected override SqlParameter[] CreateParameters(MasterVO o)
        {
            throw new NotImplementedException();
        }

        protected override string SQLDelete()
        {
            throw new NotImplementedException();
        }

        protected override string SQLFirst()
        {
            throw new NotImplementedException();
        }

        protected override string SQLInsert()
        {
            throw new NotImplementedException();
        }

        protected override string SQLLast()
        {
            throw new NotImplementedException();
        }

        protected override string SQLNext()
        {
            throw new NotImplementedException();
        }

        protected override string SQLPrevious()
        {
            throw new NotImplementedException();
        }

        protected override string SQLSearch()
        {
            throw new NotImplementedException();
        }

        protected override string SQLUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
