using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    public class Student : User
    {
        public int numGroup { get; set; }
        public string adress { get; set; }
        public int telephon { get; set; }

        public Student(int id, string name, string surname, int numGroup, string adress, int telephon, string login, string password) : base(id, name, surname, login, password)
        {
            this.numGroup = numGroup;
            this.adress = adress;
            this.telephon = telephon;
        }
    }
}
