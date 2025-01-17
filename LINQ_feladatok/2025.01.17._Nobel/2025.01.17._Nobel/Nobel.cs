using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._17._Nobel
{
    internal class Nobel
    {
        public int Evszam { get; set; }
        public string Tipus { get; set; }
        public string Keresztnev { get; set; }
        public string Vezeteknev { get; set; }

        public Nobel(string sor)
        {
            string[] strings = sor.Split(';');
            Evszam = int.Parse(strings[0]);
            Tipus = strings[1];
            Keresztnev = strings[2];
            Vezeteknev = strings[3];
        }


    }
}
