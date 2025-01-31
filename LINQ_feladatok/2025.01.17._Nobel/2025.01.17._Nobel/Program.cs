using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;


namespace _2025._01._17._Nobel
{
    internal class Program
    {
        static List<Nobel> nobels = new List<Nobel>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Felada3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Console.ReadKey();
        }

        private static void Feladat8()
        {
            Console.Write("8.Feladat: ");
            StreamWriter fajl = new StreamWriter("orvosi.txt");

            var OrvosiDijasok = nobels.Where(x => x.Tipus == "orvosi").OrderBy(x => x.Evszam).ToList();

            foreach (var item in OrvosiDijasok)
            {
                fajl.WriteLine(item.Evszam + ";"+ item.Keresztnev + " " + item.Vezeteknev);
            }
            fajl.Close();
            Console.WriteLine("orvosi.txt");

        }

        private static void Feladat7()
        {
            Console.WriteLine("7.feladat");
            var tipusokSzama = nobels.GroupBy(d => d.Tipus)
                                      .Select(g => new
                                      {
                                          Tipus = g.Key,
                                          db = g.Count()
                                      });
            foreach (var tipus in tipusokSzama)
            {
                Console.WriteLine("\t{0}\t{1} db", tipus.Tipus, tipus.db);
            }

        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat: ");
            var curieCsalad = nobels.Where(d => d.Vezeteknev.Contains("Curie"));
            foreach (var item in curieCsalad)
            {
                Console.WriteLine("\t{0}: {1} {2} ({3})", item.Evszam, item.Keresztnev, item.Vezeteknev, item.Tipus);
            }

        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat: ");
            
            var results = nobels.Where(x => x.Evszam >= 1990 && x.Tipus == "béke" && x.Vezeteknev == "");

            foreach (var item in results)
            {
                Console.WriteLine("\t {0}: {1}", item.Evszam, item.Keresztnev);
            }
        }

        private static void Feladat4()
        {
            Console.Write("4.Feladat: ");
            var results = nobels.Where(x => x.Evszam == 2017 && x.Tipus == "irodalmi");

            foreach (var item in results)
            {
                Console.WriteLine(item.Keresztnev + " " +  item.Vezeteknev);
            }
        }

        private static void Felada3()
        {
            Console.Write("3.Feladat: "); 
            var result = nobels.FirstOrDefault(x => x.Vezeteknev == "McDonald" &&  x.Keresztnev == "Arthur B.");

            if(result != null) 
            {
                Console.WriteLine("Arthur B. McDonald {0} tipusú diíjat kapott", result.Tipus);
            }
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("nobel.csv");

            f.ReadLine();
            while (!f.EndOfStream)
            {
                nobels.Add(new Nobel(f.ReadLine()));
            }
            f.Close();
        }
    }
}
