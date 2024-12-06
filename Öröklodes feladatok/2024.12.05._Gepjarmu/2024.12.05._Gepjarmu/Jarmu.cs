using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._05._Gepjarmu
{
    internal abstract class Jarmu
    {
        protected int sebesseg;
        private string rendszam;

        public Jarmu(int sebesseg, string rendszam)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorshajtottE(int sebesseg);

        public override string ToString()
        {
            return $"{rendszam} - {sebesseg} km/h";
        }

    }
}
