using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._12._Szuperhos
{
    internal abstract class Bosszuallok : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        public Bosszuallok(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public abstract bool MegmentiAVilagot();
        
    }
}
