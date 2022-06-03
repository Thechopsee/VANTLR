using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VANTLR.Struktury
{
    class Prvek
    {
        public string datovy_typ;
        public string hodnota;
        public Prvek(string typ, string hodnota)
        {
            this.datovy_typ = typ;
            this.hodnota = hodnota;

        }
        public override string ToString()
        {
            return hodnota;
        }
    }
}
