using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._05._Gepjarmu
{
    internal abstract class Jarmu
    {
        //kivulrol láthato, de csak a származtatott osztályban (protected)
        protected int sebesseg;
        private string rendszam;

        public Jarmu(int sebesseg, string rendszam)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorshajtottE(int sebesseg); //különböző féleképpen tudjuk majd megírni, hogy melyik járműnek pl mi a megfelelő sebesség

        public override string ToString()
        {
            return $"{rendszam} - {sebesseg} km/h";
        }

        internal bool HaladhatItt(int v)
        {
            throw new NotImplementedException();
        }
    }
}
