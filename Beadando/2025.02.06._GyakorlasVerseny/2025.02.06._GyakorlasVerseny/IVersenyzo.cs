using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._06._GyakorlasVerseny
{
    internal interface IVersenyzo
    {
        string ID { get; set; }
        string Nev {  get; set; }

        /// <summary>
        /// Neme tulajdonság értékei: true - férfi, false - nő
        /// </summary>
        bool Neme { get; set; }
        
    }
}
