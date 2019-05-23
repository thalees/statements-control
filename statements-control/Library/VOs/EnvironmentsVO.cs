using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class EnvironmentsVO : MasterVO
    {
        private string description;

        public string Description { get => description; set => description = value; }
    }
}
