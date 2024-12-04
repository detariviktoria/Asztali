using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._02._Pekseg
{
    internal abstract class Peksutemeny : IArlap
    {
        protected double mennyiseg;
        private double ar;

        public Peksutemeny(double mennyiseg, double ar)
        {
            this.mennyiseg = mennyiseg;
            this.ar = ar;
        }

        public abstract double Cseszekave();
        public abstract void Megkostol();
        public  double MennyibeKerul()
        {
            return ar * mennyiseg;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
