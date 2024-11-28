using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024._11._08._Hallgatok
{
    internal class Program
    {
        static List<Hallgatok> hallgatok = new List<Hallgatok>();
        static void Main(string[] args)
        {
            Hallgatok d1 = new Hallgatok("soRocd", 2,25);
            Hallgatok d2 = new Hallgatok("depwPY");

            d1.TargyFelvesz(6);
            if (d1.Vizsgazik())
                Console.WriteLine("A vizsga sikeres");
            else
                Console.WriteLine("A vizsga nem sikeres");

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());

            Feladat1();

            Console.ReadLine();


        }

        static void Feladat1()
        {
            Fajlbeolvas();
        }

        static void Fajlbeolvas()
        {
            StreamReader f = new StreamReader("hallgatok.txt");

            f.ReadLine();
            while(!f.EndOfStream)
            {
                string[] st = f.ReadLine().Split(' ');
                Hallgatok sv = new Hallgatok(st[0], Convert.ToInt32(st[1]), Convert.ToInt32(st[2]));
                hallgatok.Add(sv);
            }
            f.Close();
        }
    }

}
