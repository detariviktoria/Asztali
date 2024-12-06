using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._05._Gepjarmu
{
    internal class AudiS8 : Jarmu
    {
        private bool lezerblokkolo;

        public AudiS8(string rendszam, int sebesseg, bool lezerblokkolo) : base(sebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }
        public override bool GyorshajtottE(int sebessegkorlat)
        { 
            if (lezerblokkolo)
            {
                return false;
            }
            return sebesseg > sebessegkorlat;
        }

        public override string ToString()
        {
            return "Audi: " + base.ToString();  
        }
    }
}
