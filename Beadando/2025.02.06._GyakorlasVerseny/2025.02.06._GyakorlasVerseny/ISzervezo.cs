using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._06._GyakorlasVerseny
{
    internal interface ISzervezo
    {
        string ID { get; set; }
        void Regisztralas(VersenyTipus versenytipus, Versenyzo versenyzo, IFutas futas);
    }
}
