using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Web;
using System.Runtime.CompilerServices;

namespace _2024._09._25._Fájlbeolvasas
{
    internal class Program
    {
        static List<Kepviselo> valasztas = new List<Kepviselo>();

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Console.ReadLine();
        }

        static void Feladat5()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("5.Feladat");
             
        }

        static void Feladat4()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("4.Feladat");
            double osszes, vettreszt;
            (osszes, vettreszt) = Hanyszavazatossz();
            Console.WriteLine("A választáson {0} állampolgár, a jogosultak {1}%-a vett részt. ", osszes, vettreszt);
            
        }
        static (double, double) Hanyszavazatossz()
        {
            int jogosult = 12345;
            double osszes = 0;
            for (int i = 0; i < valasztas.Count; i++)
            {
                osszes += valasztas[i].szavazat;
            }

            double vettreszt = Math.Round(osszes / (jogosult / 100),2); // (osszes / jogosult) * 100
            return (osszes, vettreszt);
        }

        static void Feladat3()
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("3.Feladat");
            Console.WriteLine("Adjon meg egy vezetéknevet!");
            string vezeteknev = Console.ReadLine();
            Console.WriteLine("Adjon meg egy keresztnevet!");
            string keresztnev = Console.ReadLine();
            Hanyszavazat(vezeteknev, keresztnev);
        }

        static void Hanyszavazat(string v, string k)
        {
            int i = 0;
            while (i < valasztas.Count && !(valasztas[i].jeloltvnev == v && valasztas[i].jeloltknev == k))
                i++;
            {
                if(i<valasztas.Count)
                {
                    Console.WriteLine("A megadott képvselőre {0} szavazatot adtak le.",valasztas[i].szavazat);
                }
                else
                {
                    Console.WriteLine("Ilyen nevű képviselőjelölt nem szerepel a nyilvántartásban!");
                }
            }
        }


        static void Feladat2()
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("2.Feladat");
            int hossz = valasztas.Count;
            Console.WriteLine("A helyhatósági választáson {0} képviselőjelölt indult.", hossz);

        }



        static void Feladat1()
        {
            Console.WriteLine("1.Feladat");
            Fajlbeolvasas();
            
        }
        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("szavazatok.txt");

            f.ReadLine();

            while (!f.EndOfStream)
            {
                string[] s = f.ReadLine().Split(' ');
                Kepviselo k = new Kepviselo(Convert.ToInt32(s[0]), Convert.ToInt32(s[1]), s[2], s[3], s[4]);
                valasztas.Add(k);
            }
            f.Close();
        }
    }

    struct Kepviselo
    {
        public int sorszam, szavazat;
        public string jeloltvnev, jeloltknev, part;

        public Kepviselo(int sorsz, int szavaz, string jvnev, string jknev, string p)
        {
            //sorsz = sorszam;
            //szavaz = szavazat;
            sorszam = sorsz;
            szavazat = szavaz;
            jeloltvnev = jvnev;
            jeloltknev = jknev;
            part = p;
        }

    }
}
