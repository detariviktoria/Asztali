using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._10._11._Osztaly_Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Hozzon létre egy Dolgozo osztalyt
                 * - Név (konstruktorban, lekérdezhető,  nem modosítható
                 * - aktív (konstruktorban - opcionális True, lekérdezhető)
                 * - évek, amiota a cégnél dolgozik (konstruktorban - opcionális 0; lekérdezhető)
             * 
             * Metodusok:
             *      - FV: Modositsa az aktív állapotot!
             *      - FV: növeli eggyel az évek számát!
             *      - ToString();
             * Töltsön fel egy tömböt dolgozókkal! Majd jelenítse meg őket!*/
            
        }

        class Dolgozok
        {
            public string nev;
            public bool aktiv;
            public int ev;

            public Dolgozok(string nev, bool aktiv = true, int ev = 0)
            {
                this.nev = nev;
                this.aktiv = aktiv;
                this.ev = ev;
            }

            public string Nev { get { return nev; } }
            public bool Aktiv { get; }
            public int Ev { get; }
        }

    }
}
