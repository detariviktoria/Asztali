using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._23._Kosarlabda
{
    internal class Merkozes
    {
        public string Hazai { get; set; }
        public string Idegen { get; set; }
        public int Hazaipont {  get; set; }
        public int Idegenpont {get; set; }
        public string Helyszin { get; set; }
        public string Idopont { get; set; }
        public Merkozes(string sor)
        {
            string[] strings = sor.Split(';');
            Hazai = strings[0];
            Idegen = strings[1];
            Hazaipont = Convert.ToInt32(strings[2]);
            Idegenpont = Convert.ToInt32(strings[3]);
            Helyszin = strings[4];
            Idopont = strings[5];
        }
    }
}
