using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VANTLR.Struktury
{
    class Promena
    {
        public string Nazev;
        public Prvek part;
        public Promena(string nazev, Prvek prvek)
        {
            Nazev = nazev;
            part = prvek;
        }
        public override string ToString()
        {
            return Nazev;
        }
    }
}
