using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class UsersVO : MasterVO
    {
        private string name;
        private byte[] picture;
        private DateTime dtBirth;
        private string password;

        public string Name { get => name; set => name = value; }
        public byte[] Picture { get => picture; set => picture = value; }
        public DateTime DtBirth { get => dtBirth; set => dtBirth = value; }
        public string Password { get => password; set => password = value; }
    }
}
