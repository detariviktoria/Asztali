using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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

        public double MekkoraAzEreje()
        {
            return szuperero;
        }

        public bool LegyoziE(ISzuperhos ellenfel)
        {
            if (ellenfel.GetType() == typeof(Bosszuallok))
                return ((Bosszuallok)ellenfel).vanEGyengesege && ellenfel.MekkoraAzEreje() < szuperero;
            else
                return szuperero * 2 > ellenfel.MekkoraAzEreje();
        }

        public double Szuperero
        {
            get { return szuperero; }
            set { szuperero = value; }
        }
        public bool VanEGyengesege
        {
            get { return vanEGyengesege; }
            set { vanEGyengesege = value; }
        }

        public override string ToString()
        {
            return $"Szuperero: {szuperero} {(vanEGyengesege ? "Van" : "Nincs")} gyengesége";
        }


    }
}
