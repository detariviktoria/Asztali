using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace _2024._11._07._Szamitogep
{
    internal class Program
    {
        static List<Szamitogep> list = new List<Szamitogep>();
        static void Main(string[] args)
        {
            Feladat0();
        }
        static void Feladat0()
        {
            Szamitogep sz1 = new Szamitogep();
            Szamitogep sz2 = new Szamitogep(2048, false);

            Console.WriteLine(sz1.ToString());
            Console.WriteLine(sz2.ToString());

            sz1.Kikapcs();
            ProgramMasolas(sz1, 800);
            ProgramMasolas(sz1, 400);


            Beolvasas();
            Feladat2();
            Feladat3();
            Console.ReadLine();
        }


        static void Feladat3()
        {
            Console.WriteLine("3.Feladat");
            int index = LegmagasbbIndex();
            string bevane = "";
            if (list[index].bekapcs)
                bevane += "be van ";
            else
            {
                bevane += "nincs be";
            }
            Console.WriteLine("A legmagasabb memóriával rendelkező gép, {0}kapcsolva", bevane);
        }

        static int LegmagasbbIndex()
        {
            int maxi = 0;
            for (int i = 1; i<list.Count; i++)
            {
                if (list[i].memoria > list[maxi].memoria)
                {
                    maxi = i;
                }
            }
            return maxi;
        }
        static void Feladat2()
        {
            Console.WriteLine("\n2.feladat");
            int db = HanyBekapcsolt();
            Console.WriteLine("{0} db bekapcsolt gép van a számítógépek között.", db);
        }


        static int HanyBekapcsolt()
        {
            int db = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].bekapcs)
                {
                    db++;
                }
            }
            return db;
        }

        static void Beolvasas()
        {
            StreamReader f = new StreamReader("Szamitogep.txt");
            f.ReadLine();

            while(!f.EndOfStream)
            {
                string[] sv = f.ReadLine().Split('\t');
                Szamitogep szamitogep = new Szamitogep(Convert.ToDouble(sv[0]), Atalakit(sv[1]));
                list.Add(szamitogep);
            }
            f.Close();
        }

        static bool Atalakit(string bekapcs)
        {
            if (bekapcs == "x")
            {
                return true;
            }
            else
                return false; 
        }
        static void ProgramMasolas(Szamitogep sz, double hely)
        {
            if(sz.ProgramMasol(hely))
            {
                Console.WriteLine("Sikerult a másolás.");
            }
            else
            {
                Console.WriteLine("Nem sikerul a másolás");
            }
            Console.WriteLine(sz.ToString());
        }
    }
}
