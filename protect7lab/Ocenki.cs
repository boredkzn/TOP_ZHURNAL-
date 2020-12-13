using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protect7lab
{
    class Ocenki
    {
        public int id { get; set; }
        public int practica { get; set; }
        public int ocenka { get; set; }

        public Ocenki (int id, int practica, int ocenka)
        {
            this.id = id;
            this.practica = practica;
            this.ocenka = ocenka;
        }
    }
}
