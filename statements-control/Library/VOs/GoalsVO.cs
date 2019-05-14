using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    class GoalsVO
    {
        private string name;
        private DateTime endDate;
        private int idUser;

        public string Name { get => name; set => name = value; }
        public int IdUser { get => idUser; set => idUser = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
