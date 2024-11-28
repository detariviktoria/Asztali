using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._14._Static_Felhasznalasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static - pédányosítás nélkül felhasználható adatagok és metodusok
            // Példányosítás: Random rnd = new Random();
            // Példányosítás nélkül: Math.Sqrt(2);

            /*
             - tánc, jegyek eladása, osztályfőnök ...
                Static - bevétel, igazgató
             */

            string datum = "2024_11_14";

            Console.WriteLine(datum);

            Console.WriteLine($"Ev: {DatumIdo.DatumEv(datum)}");

            Console.WriteLine($"Honap: {DatumIdo.DatumHonap(datum)}");

            if (DatumIdo.SzokoevE(datum))
            {
                Console.WriteLine("Szökőév");

            }
            else
            {
                Console.WriteLine("Nem szokoev");
            }
            Console.ReadLine();
        }
    }
}
