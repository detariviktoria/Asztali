using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _2024._09._04._Ismétlés
{
    internal class Program
    {
        static Random r = new Random();
        static int[] Jancsi = new int[10];
        static int[] Juliska = new int[10];
        static void Main(string[] args)
        {
            /* Ismétlés
             * Vezérlő szerkezetek(utasítás. elágazás. ciklus)
             * Programozáási tételek
             * Metódusok (függvény, eljárás) - minden ami nem kiiratas
             * Struktúra (struct)
             * Osztályok(class)
             * Öröklődés + scope
             * Fájlbeolvasás
             * 
             * Jancsi és Juliska szerencse kockáznak.
             * Itt a számok 1-30-ig vannak, de minden 4-el osztható szám hiányzik.
             * (1,2,3,5,6,7,9,10,11,..)
             * Írj egy alkalmazást, ami kigenerál mindkettőjüknek 10-10 dobást!
             * Add meg hogy ki dobta a legtöbbszőr a legnagyobb számot!
             * Irjon egy függvényt, ami egy számról eldönti hogy prím-e!
             * */


            Feltolt(Jancsi);
            Feltolt(Juliska);

            Kiir(Jancsi);
            Kiir(Juliska);

            Feladat2();

            static void Feladat2()
            {
                Console.WriteLine()
            }

            /*int jancsiszam = Legnagyobb(Jancsi);
            int juliskaszam = Legnagyobb(Juliska);

            if(jancsiszam > juliskaszam)
            {
                int Jadb = Megszamol(jancsiszam, Jancsi);
                int Judb = Megszamol(jancsiszam, Juliska);
                
            }
            else
            {
                int Jadb = Megszamol(juliskaszam, Juliska);
                int Judb = Megszamol(juliskaszam, Jancsi);
            }*/

            bool prim = PrimE(73);
            if(prim)
            {
                Console.WriteLine("Ez a szám prímszám!");
            }
            else
            {
                Console.WriteLine("Ez a szam nem prímszám!");
            }


            Console.ReadLine();
        }



        static bool PrimE(int szam)
        {
            int i = 2;
            while (i <= szam-1 && !(szam % i == 0))
                i++;
            if(i>=szam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static int Megszamol(int szam, int[] tomb)
        {
            int db = 0;
            for (int i = 0;i<tomb.Length; i++)
            {
                if (tomb[i] == szam)
                {
                    db++;
                }
            }
            return db;
        }
        static void Feltolt(int[] tomb)
        {

            for (int i = 0; i < tomb.Length; i++)
            {
                int a;
                do
                {
                    a = r.Next(1, 31);
                    tomb[i] = a;
                }
                while (a % 4 == 0);
            }
        }

        static void Kiir(int[] tomb)
        {
            for (int i = 0;i<tomb.Length;i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static int Legnagyobb(int[] tomb)
        {
            int maxi = 0;
            for (int i = 1;i < tomb.Length; i++)
            {
                if (tomb[i] > tomb[maxi])

                {
                    maxi = i;
                }
            }
            return maxi;
        }
    }
}
