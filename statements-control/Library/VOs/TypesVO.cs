using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class TypesVO : MasterVO
    {
        private string description;
        private string action;

        public string Description { get => description; set => description = value; }
        public string Action { get => action; set => action = value; }
    }
}
