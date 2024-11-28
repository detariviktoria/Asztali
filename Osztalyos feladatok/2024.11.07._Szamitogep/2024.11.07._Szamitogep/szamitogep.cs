using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._07._Szamitogep
{
    internal class Szamitogep
    {
        //Adattagok
        public double memoria;
        public bool bekapcs;

        // Konstruktor
        public Szamitogep(double memoria, bool bekapcs)
        {
            this.memoria = memoria;
            this.bekapcs = bekapcs;
        }

        

        public Szamitogep()
        {
            memoria = 1024;
            bekapcs = false;    
        }

        public void Kikapcs()
        {
            if(bekapcs)
            {
                bekapcs = false;
            }
            else
            {
                bekapcs = true;
            }

            // bekapcsolva = !bekapcsolva;
        }

        public bool ProgramMasol(double meret)
        {
            if (memoria - meret >= 0 && bekapcs == true)
            {
                memoria = memoria - meret;
                return true;
            }
            else { return false; }
        }

        public override string ToString()
        {
            return string.Format("Memoria: {0},Be van-e kapcsolva: {1}",memoria, bekapcs);
        }
    }

}
