using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string login { get; set; }
        public string password { get; set; }

        public User()
        {

        }
        public User(int id, string name, string surname, string login, string password)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.password = password;
        }
    }
}
