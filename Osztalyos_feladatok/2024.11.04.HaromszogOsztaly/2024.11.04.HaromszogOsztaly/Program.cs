using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Schema;
namespace _2024._11._04.HaromszogOsztaly
{
    internal class Program
    {
        static List<Haromszog> haromszogek = new List<Haromszog>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat1();
            Feladat2();

            Console.ReadLine();
        }

        static void Feladat2()
        {
            Console.WriteLine("2.Feladat");
            int index = LegnagyobbTerulet();
            Haromszog sv = haromszogek[index];
            Console.WriteLine("Legnagyobb teruletu haromszog oldalai: {0} {1} {2}", sv.A, sv.B, sv.C);
        }

        static int LegnagyobbTerulet()
        {
            int maxi = 0;
            for(int i = 0; i< haromszogek.Count; i++)
            {
                if (haromszogek[i].SzerkeszthetoE() && haromszogek[i].Terulet() > haromszogek[maxi].Terulet())
                {
                    maxi = i;
                }
            }
            return maxi;
        }
        static void Feladat1()
        {
            Console.WriteLine("1.Feladat");
            int db = HanySzerkeszheto();
            Console.WriteLine("Ennyi db nem szerkeszthető háromszög van: " + db);
        }

        static int HanySzerkeszheto()
        {
            int db = 0;
            for (int i = 0;i<haromszogek.Count; i++)
            {
                if (haromszogek[i].SzerkeszthetoE() == true)
                {
                    db++;
                }
            }
            return haromszogek.Count-db;
        }

        static void Beolvasas()
        {
            StreamReader f = new StreamReader("haromszogek.txt");

            string line = f.ReadLine();
            while (!f.EndOfStream)
            {
                string sor = f.ReadLine();
                Haromszog sv = new Haromszog(sor);
                haromszogek.Add(sv);
            }
            f.Close();
        }

        

    }
}
