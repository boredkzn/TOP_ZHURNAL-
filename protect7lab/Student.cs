using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    public class Student : User
    {
        public Group numGroup { get; set; }

        public List <Subject> subject;

        public Student(int id, string name, string surname, Group numGroup, string login, string password) : base(id, name, surname, login, password)
        {
            this.numGroup = numGroup;
            subject = new List<Subject>();
        }
        public Student() : base()
        {

        }
        public Subject FindSubject(string Subject)
        {
            foreach (var item in subject)
            {
                if (item.NameSubject.nameSubject == Subject)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
