using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._06._GyakorlasVerseny
{
    internal class Versenyzo : IVersenyzo
    {
        public string ID { get; set; }
        public string Nev { get; set; }
        public bool Neme { get; set; }

        public Dictionary<VersenyTipus, Futas> Eredmenyek = new Dictionary<VersenyTipus, Futas>();

        public void VersenyzoEredmenye(VersenyTipus versenytipus)
        {
            Eredmenyek.Add();
        }
    }
}
