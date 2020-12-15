using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    public class Group
    {
        public int id { get; set; }
        public List<Student> sostavGroup { get; set; }

        public Group(int id)
        {
            this.id = id;
            this.sostavGroup = new List<Student>();
        }
    }
}
