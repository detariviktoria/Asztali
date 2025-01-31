using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace _2025._01._23._Magyarorszaghegyei
{
    internal class Program
    {
        static List<Hegyek> hegyeks = new List<Hegyek>();
        static void Main(string[] args)
        {
            FajlBeolvas();

            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Feladat7();
            Feladat8();
            Feladat9();

            Console.ReadKey();
        }

        private static void Feladat9()
        {
            StreamWriter streamWriter = new StreamWriter("bukk-videk.txt");

            var buklvidek = hegyeks.Where(x => x.Hegyseg == "Bükk-vidék");

            streamWriter.WriteLine("Hegycsúcs neve, Magasság láb");
            foreach (var item in buklvidek)
            {
                string labban = Convert.ToString(Math.Round(item.Magassag * 3.280839895, 1));
                streamWriter.WriteLine(item.HegyCsucs + ";" + labban );
            }
            streamWriter.Close();
            Console.WriteLine("9.Feladat: bukk-videk.txt");
        }

        private static void Feladat8()
        {
            Console.WriteLine("\n8.Feladat: Hegység statisztika");
            var result = hegyeks.GroupBy(x => x.Hegyseg)
                .Select(x => new
                {
                    Hegyseg = x.Key,
                    db = x.Count()
                });
            foreach (var item in result)
            {
                Console.WriteLine("\t{0} - {1} db", item.Hegyseg, item.db);
            }
        }

        private static void Feladat7()
        {
            Console.Write("7.Feladat: 3000 lábnál magasabb hegycsúcsok száma: ");
            var result = hegyeks.Count(x => x.Magassag * 3.280839895 > 3000);

            Console.Write(result);
        }

        private static void Feladat6()
        {
            Console.Write("6.Feladat: Kérek egy magasságot: ");
            int mag = Convert.ToInt32(Console.ReadLine());
            var result = hegyeks.Any(x => x.Magassag > mag && x.Hegyseg == "Börzsöny");

            if(result)
            {
                Console.WriteLine("\tVan {0}-nál magasabb hegycsúcs Börzsönyben!", mag);
            }
            else
            {
                Console.WriteLine("\tNincs {0}-nál magasabb hegycsúcs Börzsönyben!", mag);
            }
        }

        private static void Feladat5()
        {
            Console.WriteLine("\n5. Feladat: A legmagasabb hegycsúcs adatai:");
            var result = hegyeks.OrderByDescending(x => x.Magassag).First();

            Console.WriteLine("\tNév: {0} \n\tHegység: {1} \n\tMagasság: {2}", result.HegyCsucs, result.Hegyseg, result.Magassag);
        }

        private static void Feladat4()
        {
            var result = hegyeks.Average(x => x.Magassag);
            Console.Write("4.Feladat: Hegycsúcsok átlagos magassága: {0} m", result);
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.feladat : Hegycsúcsok száma: {0}", hegyeks.Count);
        }

        private static void FajlBeolvas()
        {
            StreamReader f = new StreamReader("hegyekMo.txt");

            f.ReadLine();
            while (!f.EndOfStream)
            {
                hegyeks.Add(new Hegyek(f.ReadLine()));
            }
            f.Close();
        }
    }
}
