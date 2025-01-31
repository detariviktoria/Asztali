using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;

namespace _2025._01._23._Kosarlabda
{
    internal class Program
    {
        static List<Merkozes> merkozesek = new List<Merkozes>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Feladat3();
            Feladat4();

            Console.ReadLine();
        }

        private static void Feladat4()
        {
            
        }

        private static void Feladat3()
        {
            
            int hazai = merkozesek.Where(x => x.Hazai == "Real Madrid").Count();
            int idegen = merkozesek.Where(x => x.Idegen == "Real Madrid").Count();
            Console.WriteLine("3.Feladat: Real Madrid: Hazai: {0}, Idegen: {1}", hazai, idegen);
        }

        private static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("eredmenyek.csv");

            f.ReadLine();
            while (!f.EndOfStream)
            {   
                merkozesek.Add(new Merkozes(f.ReadLine()));
                
            }
            f.Close();
        }
    }
}
