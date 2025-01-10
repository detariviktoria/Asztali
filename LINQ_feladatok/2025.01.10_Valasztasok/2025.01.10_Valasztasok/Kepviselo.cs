using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._10_Valasztasok
{
    internal class Kepviselo
    {

        public int Sorszam { get; set; }
        public int Szavazat { get; set; }
        public string Jeloltnev { get; set; }
        public string Jeloltknev { get; set; }
        public string Part { get; set; }


        public int sorszam, szavazat;
        public string jeloltvnev, jeloltknev, part;

            public Kepviselo(string sor)
            {
                string[] s = sor.Split(' ');

                sorszam = Convert.ToInt32(s[0]);
                szavazat = Convert.ToInt32(s[1]);
                jeloltvnev = s[2];
                jeloltknev = s[3];
                part = s[4];
            }

        
    }
}
