using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class EnvironmentsVO : MasterVO
    {
        private string name;

        public string Name { get => name; set => name = value; }
    }
}
