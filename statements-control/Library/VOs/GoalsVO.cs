using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    class GoalsVO : MasterVO
    {
        private DateTime endDate;
        private int userId;

        public int UserId { get => userId; set => userId = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
