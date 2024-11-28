using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._08._Hallgatok
{
    internal class Hallgatok
    {
        public string azonosito;
        public int evfolyam, kreditszam;

        public Hallgatok(string azonosito, int evfolyam, int kreditszam)
        {
            this.azonosito = azonosito;
            this.evfolyam = evfolyam;
            this.kreditszam = kreditszam;
        }

        public Hallgatok(string azonosito)
        {
            this.azonosito = azonosito;
            evfolyam = 1;
            kreditszam = 0;
        }

        public void TargyFelvesz(int kredit)
        {
            kreditszam += kredit;
        }

        public bool Vizsgazik()
        {
            if (kreditszam < 0)
            {
                evfolyam += 1;
                kreditszam = 0;
                return true;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return string.Format("Azonosító: {0}, Évfolyam:{1}, Kreditszam: {2}", azonosito, evfolyam, kreditszam);
        }
    }

      
}
