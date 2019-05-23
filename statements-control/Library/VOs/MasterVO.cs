using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public abstract class MasterVO
    {
        private int id;
        private string name;
        public virtual int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
