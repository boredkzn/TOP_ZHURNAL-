using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    public static class Konteiner
    {
        public static List<Group> kontainGroup;
        public static List<Student> kontainStud;
        public static List<Prepod> kontainPrepod; 

        static Konteiner()
        {
            kontainGroup = new List<Group>();
            kontainStud = new List<Student>();
            kontainPrepod = new List<Prepod>();

            kontainGroup.AddRange(new List<Group>(){ new Group(4232, "Индус", "Лерок"), new Group(4294, "Заид", "Дина")});
        }
    }
}
