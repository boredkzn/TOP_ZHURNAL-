using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protect7lab
{
    public static class Konteiner
    {
        public static List<Group> kontainGroup;
        public static List<Student> kontainStud;
        public static List<Prepod> kontainPrepod;
        public static List<Subject> kontainSubjects;
        public static List<NameSubject> kontainNamesSubjects;

        public static Group findGroup(int id)
        {
            foreach (var item in kontainGroup)
            {
                if(item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Subject FindSubject(string subject)
        {
            foreach (var item in kontainSubjects)
            {
                if (item.NameSubject.nameSubject == subject)
                {
                    return item;
                }
            }
            return null;
        }
        public static NameSubject findNameSubject(string name)
        {
            foreach (var item in kontainNamesSubjects)
            {
                if (item.nameSubject == name)
                {
                    return item;
                }
            }
            return null;
        }
        static Konteiner()
        {
            kontainGroup = new List<Group>();
            kontainStud = new List<Student>();
            kontainPrepod = new List<Prepod>();
            kontainSubjects = new List<Subject>();
            kontainNamesSubjects = new List<NameSubject>();

            kontainGroup.AddRange(new List<Group>() { new Group(4232), new Group(4294) });
            kontainStud.AddRange(new List<Student>() { new Student(1, "Шамиль", "Зарипов", findGroup(4232), "100", "100"), new Student(2, "Булат", "Шарипов", findGroup(4232), "200", "200"), new Student(3, "Заид", "Мингалиев", findGroup(4294), "200", "200") });
            kontainNamesSubjects.Add(new NameSubject("ОАИП"));

            foreach (var item in kontainStud)
            {
                findGroup(item.numGroup.id).sostavGroup.Add(item);
                item.subject.Add(new Subject(findNameSubject("ОАИП")));
            }

            kontainPrepod.Add(new Prepod(4, "Заид", "Мингалиев", FindSubject("ОАИП"), "10", "10"));

            
        }
    }
}
