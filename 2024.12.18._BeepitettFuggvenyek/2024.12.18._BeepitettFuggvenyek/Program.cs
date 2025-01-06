using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._18._BeepitettFuggvenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzamosBeepitettFuggvenyek();
            Console.ReadLine();
        }

        private static void SzamosBeepitettFuggvenyek()
        {
            List<int> egeszek = new List<int>() { 2, 82, 23, 90, 27, 65, 24, 89 };

            /* Kiiratás - foreach */
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            /* Sum -  Összegzes*/
            int sum = egeszek.Sum();
            Console.WriteLine("Összeg: "+ sum);

            /* Average - Átlag*/
            double avg = egeszek.Average();
            Console.WriteLine("Átlag: " + avg);

            /* Min - Minimum */
            double min = egeszek.Min();
            Console.WriteLine("Minimum érték" + min);

            /* Max - Maximum*/
            double max = egeszek.Max();
            Console.WriteLine("maximum érték" + max);

            /* IndexOf - megadja az indexét a keresett elemnek
             Ha van benne az index értékével tér vissza, különben -1*/
            int szam = 25;
            int index = egeszek.IndexOf(szam);
            Console.WriteLine($"Keresett elem: {szam} indexe:" + $"{(index == -1 ? "Nincs benne" :""+ index)}");

            /* Contains - Van-e a szerekezetben a keresett elem.*/
            bool vane = egeszek.Contains(szam);
            Console.WriteLine($"{(vane ? "Benne van a ": "Nincs benne a")} {szam}");

            /* Remove - törli az első elemet, ami megadunk, és visszatér a törlés eredményével */

            if (egeszek.Remove(szam))
            {
                foreach (int a in egeszek) Console.Write(a + " ");
                Console.WriteLine();
            }
            else
                Console.WriteLine($"Nincs a listában a törlendő elem ({szam})");

            /* RemoveAt - index alapján törli az elemet */
            egeszek.RemoveAt(0);

            /* Sort - rendezes */
            egeszek.Sort();
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            Console.WriteLine("Első elem: " + egeszek.First());
            Console.WriteLine("Utolsó elem: " + egeszek.Last());

            // Elem hozzáadása megadott indexre
            egeszek.Insert(1, 2); // hova, mit
            foreach (int a in egeszek) Console.Write(a + " ");
            Console.WriteLine();

            // InsertRange - Listához lista fűzés
            List<int> list = new List<int>() { 1,2,3};
            list.InsertRange(0, egeszek);

            foreach (int a in list) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
}
