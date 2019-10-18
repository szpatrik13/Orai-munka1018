using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai_munka1018
{
    class Jatekos
    {
        public string Nev { get; set; }
        public int Evesfizetes { get; set; }

        public int Evek { get; set; }

        public Jatekos(string nev, int evesfizetes, int evek)
        {
            Nev = nev;
            Evesfizetes = evesfizetes;
            Evek = evek;
        }
    }
}
