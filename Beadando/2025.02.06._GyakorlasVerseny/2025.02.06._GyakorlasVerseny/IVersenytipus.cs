using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._06._GyakorlasVerseny
{
    internal interface IVersenytipus
    {
        string ID { get; set; }
        int Hossz { get; set; }
        DateTime Datum { get; set; }
    }
}
