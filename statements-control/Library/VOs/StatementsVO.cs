using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class StatementsVO : MasterVO
    {
        private int userId;
        private int typeId;
        private int environmentId;
        private double value;
        private DateTime date;

        public int UserId { get => userId; set => userId = value; }
        public int TypeId { get => typeId; set => typeId = value; }
        public int EnvironmentId { get => environmentId; set => environmentId = value; }
        public double Value { get => value; set => this.value = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
