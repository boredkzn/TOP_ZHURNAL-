using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    public class Prepod : User
    { 
        public string predmet { get; set; }
        public Prepod(int id, string name, string surname, string predmet, string login, string password) : base(id, name, surname, login, password)
        {
            this.predmet = predmet;
        }

        public Prepod(int id, string name, string surname, string login, string password) : base(id, name, surname, login, password)
        {
        }
    }
}
