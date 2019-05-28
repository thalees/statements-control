using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class InvestmentsVO : MasterVO
    {
        private double value;
        private DateTime startDate;
        private DateTime endDate;
        private int userId;

        public double Value { get => value; set => this.value = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}

