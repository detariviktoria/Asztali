using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025._01._17._Nobel
{
    internal class Program
    {
        static List<Nobel> nobels = new List<Nobel>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            Felada3();
        }

        private static void Felada3()
        {
            var result = nobels.Where(x => x.vezeteknev == "McDonald" &&  x.keresztnev == "Arthur B.");

            foreach (var item in nobels)
            {
                Console.WriteLine("Arthur B. McDonald {0} tipusú dijat kapott", result.Tipus);
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
