using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._10_Valasztasok
{
    internal class Program
    {
        static List<Kepviselo> valasztasok = new List<Kepviselo>();
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Console.ReadKey();
        }


        static void Feladat4()
        {
            Console.WriteLine("4.Feladat");
            int szavazatok = HanySzavazat();
            double szazalek = (double)szavazatok / 12345 * 100;
            Console.WriteLine("A választáson {0} állampolgár, a jogosultak {1}%-a vett részt.", szavazatok, Math.Round(szazalek, 2));
        }

        static int HanySzavazat()
        {
            var result = valasztasok.Sum(x => x.szavazat);
            return result;
        }

        static void Feladat3()
        {
            Console.WriteLine("3.Feladat");
            Console.WriteLine("Adj meg egy vezetéknevet:");
            string vezetek = Console.ReadLine();
            Console.WriteLine("Adj meg egy utónevet:");
            string uto = Console.ReadLine();
            bool vane = VanEIlyenKepviselo(vezetek, uto);
            Console.WriteLine(vane == true ? "Ilyen nevű képviselőjelölt szerepel a nyilvántartásban!" : "Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");

        }
        static bool VanEIlyenKepviselo(string vez, string uto)
        {
            var result = valasztasok.Where(x => x.jeloltvnev == vez && x.jeloltknev == uto);

            return result.Count() > 0;
        }

        static void Feladat2()
        {
            Console.WriteLine("1.Feladat");
            int kepviselo = HanyKepviselo();
            Console.WriteLine("A helyhatósági választáson {0} képviselőjelölt indult. ",kepviselo);
        }

        static int HanyKepviselo()
        {
            return valasztasok.Count;
        }


        static void Feladat1()
        {
            Console.WriteLine("1.Feladat");
            Fajlbeolvasas();
        }

        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("szavazatok.txt");

            while (!f.EndOfStream)
            {
                string sor = f.ReadLine();
                Kepviselo k = new Kepviselo(sor);
                valasztasok.Add(k);
            }
            f.Close();
        }

        
    }
}
