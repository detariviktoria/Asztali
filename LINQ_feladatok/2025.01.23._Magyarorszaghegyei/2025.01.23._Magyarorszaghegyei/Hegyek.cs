using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._23._Magyarorszaghegyei
{
    internal class Hegyek
    {
        public string HegyCsucs {get; set; }
        public string Hegyseg { get; set; }
        public int Magassag { get; set; }

        public Hegyek(string sor)
        {
            string[] f = sor.Split(';');
            HegyCsucs = f[0];
            Hegyseg = f[1];
            Magassag = Convert.ToInt32(f[2]);
        }
    }
}
