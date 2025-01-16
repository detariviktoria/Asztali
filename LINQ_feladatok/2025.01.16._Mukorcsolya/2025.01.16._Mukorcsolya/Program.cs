using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._16._Mukorcsolya
{
    internal class Program
    {
        static List<Korcsolya> dontos = new List<Korcsolya>();
        static List<Korcsolya> rovidprograms = new List<Korcsolya>();
        static void Main(string[] args)
        {
            Fajlbeolvasas(dontos, "donto.csv");
            Fajlbeolvasas(rovidprograms, "rovidprogram.csv");
            Feladat2();
            Feladat3();
            //Feladat4();
            Feladat5();
            
            Feladat7();
            
            Console.ReadLine();
        }

        private static void Feladat6(string nev)
        {
            Console.WriteLine("6. feladat");
            double osszpont = OsszPontSzam(nev);
            Console.WriteLine("\tA versenyző összepontszáma: {0}", osszpont);
        }

        private static void Feladat7()
        {
            Console.WriteLine("7. feladat");
            var orszagLista = dontos
                .GroupBy(versenyzo => versenyzo.Orszag)
                .Where(csoport => csoport.Count() > 1)
                .Select(csoport => new 
                { 
                    orszag = csoport.Key,
                    szam = csoport.Count()
                });

            foreach (var orszag in orszagLista)
            {
                Console.WriteLine("\t{0}: {1} versenyzo", orszag.orszag, orszag.szam);
            }
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat");
            Console.Write("\tKerem a versenyzo nevet: ");
            string bekertNEv = Console.ReadLine();
            bool voltEilyen = rovidprograms.Any(versenyzo => versenyzo.Nev == bekertNEv);
            if (!voltEilyen)
            {
                Console.WriteLine("\tIlyen nevu indulo nem volt"); 
            }
            else
            {
                Feladat6(bekertNEv);
            }
        }

        

        static double OsszPontSzam(string nev)
        {
            double osszPont = 0;
            foreach (Korcsolya i in rovidprograms)
            {
                if (i.Nev == nev)
                {
                    osszPont += i.TechPontszam + i.KompPontszam - i.Levonas;
                }
            }

            foreach (Korcsolya i in dontos)
            {
                if (i.Nev == nev)
                {
                    osszPont += i.TechPontszam + i.KompPontszam - i.Levonas;
                }
            }
            return osszPont;
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat");
            bool BejutottE = dontos.Any(versenyzo => versenyzo.Orszag == "HUN");
            Console.WriteLine(BejutottE ? "\tA magyar versenyzo bejutott a kűrbe" : "\tA magyar versenyzo nem jutott be a kűrbe");
        }

        private static void Feladat2()
        {
            Console.WriteLine("3.Feladat");
            Console.WriteLine("\tA rövidprogramban {0} induló volt.", rovidprograms.Count);
        }

        private static void Fajlbeolvasas(List<Korcsolya> fajl, string utvonal)
        {
            StreamReader sd = new StreamReader(utvonal);
            sd.ReadLine();
            while (!sd.EndOfStream)
            {
                fajl.Add(new Korcsolya(sd.ReadLine()));
            }
            sd.Close();
        }

        class Korcsolya
        {
            public string Nev;
            public string Orszag;
            public double TechPontszam;
            public double KompPontszam;
            public int Levonas;

            public Korcsolya(string Sor)
            {
                string[] AdatSorElemek = Sor.Split(';');
                Nev = AdatSorElemek[0];
                Orszag = AdatSorElemek[1];
                TechPontszam = Convert.ToDouble(AdatSorElemek[2].Replace(".", ","));
                KompPontszam = Convert.ToDouble(AdatSorElemek[3].Replace(".", ","));
                Levonas = Convert.ToInt32(AdatSorElemek[4]);
            }


        }
    }
}
