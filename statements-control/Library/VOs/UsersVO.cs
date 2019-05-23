using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.VOs
{
    public class UsersVO : MasterVO
    {
        private byte[] picture;
        private DateTime dateBirth;
        private string password;

        public byte[] Picture { get => picture; set => picture = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string Password { get => password; set => password = value; }
    }
}
