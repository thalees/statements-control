using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    class GoalsVO : MasterVO
    {
        private string name;
        private DateTime endDate;
        private int userId;

        public string Name { get => name; set => name = value; }
        public int UserId { get => userId; set => userId = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
