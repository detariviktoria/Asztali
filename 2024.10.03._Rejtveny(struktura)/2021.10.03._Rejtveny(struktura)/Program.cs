using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021._10._03._Rejtveny_struktura_
{

    internal class Program
    {
        static int[,] feladvany = new int[10, 10];
        static List<Megoldas> megoldasok = new List<Megoldas>();
        static void Main(string[] args)
        {
            Fajlbeolvasas();
            FajlbeolvasasMegoldasok();

            Kiiratas();

            Console.ReadLine();
            //Feladat1();
            Feladat3();
        }
        
        static void Feladat3()
        {
            for (int i = 0; i < megoldasok.Count; i++) 
            {
                if (UgyanazE(megoldasok[i].megoldas, feladvany))
                {
                    Console.WriteLine(megoldasok[i].nev);
                }
            }
        }

        static bool UgyanazE(int[,] megoldas, int[,] feladvany)
        {
            bool vege = false;
            int i = 0;
            while (!vege)
            {
                int j = 0;
                while (j < feladvany.GetLength(0) && megoldas[i, j] == feladvany[i, j])
                { j++; }
                if (j < feladvany.GetLength(0))
                    vege = true;
                else
                    i++;
            }
            return vege = true;
        }

        static void MatrixBeolvasas(StreamReader f, int[,] matrix)
        {
            for (int i = 0; i <10; i++)
            {
                string[] st = f.ReadLine().Split(' ');
                for (int j = 0; j<st.Length; j++)
                {
                    matrix[i,j] = Convert.ToInt32(st[j]);
                }
            }
        }
        static void FajlbeolvasasMegoldasok()
        {
            StreamReader f = new StreamReader("megoldas.txt");
            int m = Convert.ToInt16(f.ReadLine());

            while (!f.EndOfStream)
            {
                int[,] sm = new int[10, 10];
                string nev = f.ReadLine();
                MatrixBeolvasas(f, sm);
                /*for(int i = 0;i<m; i++)
                {
                    string[] st = f.ReadLine().Split(' ');
                    for (int j = 0; j < st.Length; j++)
                        sm[i, j] = Convert.ToInt16(st[j]);
                    
                }*/
                Megoldas sv = new Megoldas(nev, sm);
                megoldasok.Add(sv);
                
            }
            f.Close();

        }
        static void Feladat1()
        {
            int sor;
            do
            {
                Console.WriteLine("Adjon meg egy sor számot!: ");
                sor = Convert.ToInt16(Console.ReadLine());
            }
            while ((sor < 0) || (sor > 10));

            int oszlop;
            do
            {
                Console.WriteLine("Adjon meg egy oszlop számot!: ");
                oszlop = Convert.ToInt16(Console.ReadLine());
            }
            while ((oszlop < 0) || (oszlop > 10));

        }

        static void Kiiratas()
        {
            for (int i = 0; i < feladvany.GetLength(0); i++)
            {
                for (int j = 0; j < feladvany.GetLength(1); j++)
                {
                    Console.Write(feladvany[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void Fajlbeolvasas()
        {
            StreamReader f = new StreamReader("feladvany.txt");
            MatrixBeolvasas(f, feladvany);
            /*int i = 0;
            while (!f.EndOfStream)
            {
                string[] sor = f.ReadLine().Split(' ');
                for (int j = 0; j < matrix.GetLength(0); j++)
                    matrix[i, j] = Convert.ToInt16(sor[j]);
                i++;
            }
            f.Close();*/
        }

    }

    struct Megoldas
    {
        // adattagok
        public string nev;
        public int[,] megoldas;

        // konstruktor
        public Megoldas(string nev, int[,] matrix)
        {
            this.nev = nev;
            megoldas = matrix;
        }
    }
}