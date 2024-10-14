using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._10._10._Dolgozat1
{
    internal class Program
    {
        static List<Versenyzo> lista = new List<Versenyzo>();
        static void Main(string[] args)
        {
            FajlBeolvasas();
        }

        static void FajlBeolvasas()
        {
            StreamReader f = new StreamReader("Selejtezo2012.txt");

            f.ReadLine();
            while(!f.EndOfStream)
            {
                string line = f.ReadLine();
                Versenyzo sv = new Versenyzo(line);
                lista.Add(sv);
            }
            f.Close();
        }
    }
    
    struct Versenyzo
    {
        //3.feladat
        public string nev, csoport, nemzeteskod;
        public double d1, d2, d3;

        
        public Versenyzo(string sor)
        {
            string[] st = sor.Split(';');
            nev = st[0];
            csoport = st[1];
            nemzeteskod = st[2];
            d1 = Atalakit(st[3]);
            d2 = Atalakit(st[4]);
            d3 = Atalakit(st[5]);

        }

        double Atalakit(string st)
        {
            if (st == "X")
            {
                return -2;
            }
            else if(st == "-")
                return -1;
            else
                return Convert.ToDouble(st);
        }
    }
}
