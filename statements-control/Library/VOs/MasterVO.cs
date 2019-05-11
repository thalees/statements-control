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
        public virtual int Id { get => id; set => id = value; }
    }
}
