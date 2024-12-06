using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._05._Gepjarmu
{
    internal class Robogo : Jarmu, IKisGepjarmu
    {
        private int maxsebesseg;

        public Robogo(string rendszam, int sebesseg, int maxsebesseg):base(sebesseg, rendszam)
        {
            this.maxsebesseg = maxsebesseg;
        }

        public override bool GyorshajtottE(int sebesseg)
        {
            return sebesseg < maxsebesseg;
        }

        public bool HaladhatItt(int s)
        {
            return sebesseg < s;
        }

        public override string ToString()
        {
            return "Robogo: " + base.ToString();  // Az ősosztály toString metodus hasznalata
        }
    }
}
