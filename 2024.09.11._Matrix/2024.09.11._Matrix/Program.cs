using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._11._Matrix
{
    internal class Program
    {
        static Random r = new Random();
        static int[,] matrix;
        static void Main(string[] args)
        {

            Feladat1();
            Feladat2();
            Feladat3();
            Console.ReadLine();

            //hf: Adja meg annak az elemnek a sorát és oszlopát melyiknek a szomszédjainak átlaga a legnagyobb
        }


        static void Feladat3()
        {

            List<double> list2 = new List<double>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    List<int> szomszedok = Szomszedok(i, j);
                    double atlag = Atlag(szomszedok);
                    list2.Add(atlag);

                }
            }
            ListaKiir2(list2);
            int maxindex = Maxi(list2);
            Console.WriteLine(maxindex-1);
        }

        static int Maxi(List<double> lista)
        {
            int maxi = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > lista[maxi])
                {
                    maxi = i;
                }
            }
            return maxi;
        }

        static double Atlag(List<int> jel)
        {
            int osszeg = 0;
            for (int i = 0; i < jel.Count; i++)
            {
                osszeg += jel[i];
            }
            double a = Convert.ToDouble(osszeg / jel.Count);
            return a;
        }

        static void Feladat2()
        {
            Console.Write("Adj meg egy sorszámot!: ");
            int sor = Convert.ToInt16(Console.ReadLine());
            Console.Write("Adj meg egy oszlopszámot!: ");
            int oszlop = Convert.ToInt16(Console.ReadLine());
            List<int> szomszedok = Szomszedok(sor, oszlop);
            ListaKiir(szomszedok);
        }

        static List<int> Szomszedok(int sor, int oszlop)
        {
            List<int> list = new List<int>();
            for (int i = -1; i < 2; i++)
            {
                for(int j = -1; j < 2; j++)
                {
                    if(sor+i > -1 && oszlop+j> -1 && sor+i<matrix.GetLength(0) && oszlop+j<matrix.GetLength(1) && (i != 0 || j != 0))
                    {
                        list.Add(matrix[sor+i, oszlop+j]);
                    }
                }
            }
            return list;
        }

        static void ListaKiir(List<int> list)
        {
            for(int i =  0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();    
        }

        static void ListaKiir2(List<double> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        static void Feladat1()
        {
            Console.Write("Adja meg a mátrix sorát: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a mátrix oszlopát: ");
            int oszlopszam = Convert.ToInt32(Console.ReadLine());
            matrix = new int[sorszam, oszlopszam];
            Feltoltes(matrix);
        }

        static void Feltoltes(int[,] mtomb)
        {
            for (int i = 0; i < mtomb.GetLength(0); i++)
            {
                for (int j = 0; j < mtomb.GetLength(1); j++)
                {

                    mtomb[i, j] = r.Next(0, 1000);
                    if(mtomb[i, j] < 10 )
                        Console.Write( "   " + mtomb[i, j] );
                    else if(mtomb[i, j] < 100 && mtomb[i, j] > 9)
                    {
                        Console.Write("  " + mtomb[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + mtomb[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
