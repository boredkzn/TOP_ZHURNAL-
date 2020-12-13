using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    class Predmet
    {
        public int id { get; set; }
        public string nazvanie { get; set; }
        public string prepod { get; set; }

        public Predmet(int id, string nazvanie, string prepod)
        {
            this.id = id;
            this.nazvanie = nazvanie;
            this.prepod = prepod;
        }
    }
}
