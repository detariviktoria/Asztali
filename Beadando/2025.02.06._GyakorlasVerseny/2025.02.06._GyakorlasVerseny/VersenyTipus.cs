using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._06._GyakorlasVerseny
{
    internal class VersenyTipus : IVersenytipus
    {
        public string ID { get; set; }
        public int Hossz { get; set; }
        public DateTime DateTime { get; set; }
    }
}
