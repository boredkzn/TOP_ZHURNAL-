using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    class DekanatAdmin
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }

        public DekanatAdmin (int id, string login, string password, string name)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.name = name;
        }
    }
}
