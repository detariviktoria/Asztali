using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._16._Struktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutya k1 = new Kutya(); // strukturának egy példánya
            k1.kor = 12;
            k1.nev = "Trixi";
            k1.faja = "puli";
            //Console.WriteLine(k1.ToString() + " " + k1.oltasokDatuma.ToString());




            Kutya k2 = new Kutya(15, "Morzsi", "Vizsla", true);
            Console.WriteLine(k2.ToString() + " " + k2.oltasokDatuma.ToString());
            //Console.WriteLine("{0} {1} {2} {3} ", k1.kor, k1.nev, k1.faja, k1.kan);

            Kutya k3 = k2;
            k3.faja = "tacsko";

            List<Kutya> kutyak = new List<Kutya>();
            kutyak.Add(k1);
            kutyak.Add(k2);
            kutyak.Add(k3);

            for (int i = 0; i < kutyak.Count; i++)
            {
                Console.WriteLine(kutyak[i].ToString());
            }

            int maxi = 0;
            for (int j = 1; j < kutyak.Count; j++)
            {
                if (kutyak[j].kor > kutyak[j].kor)
                {
                    maxi = j;
                }
            }
            Console.WriteLine(kutyak[maxi].nev);
            Console.ReadLine();
        }

        // Struktura
        struct Kutya
        {
            public int kor;
            public string nev, faja;
            public bool kan;
            public List<string> oltasokDatuma;

            // Konstruktor
            public Kutya(int ujkor, string ujnev, string ujfajta, bool kan)
            {
                this.kor = ujkor; this.nev = ujnev; this.faja = ujfajta; this.kan = kan; 
                oltasokDatuma = new List<string>() { "2022.05.04." };
            }

            // Metodus
            public override string ToString()
            {
                return string.Format("{0} {1} {2} {3} ", kor, nev, faja, kan);
            }

            // hf. 09.16. valamilyen állat kiválasztása 5 mezővel, kivűlről lehessen beküldeni TOSTRING kiiratas !!!
            // hf.09.18. listaban eltárolni, hogyan hivatkozunk az elemekre, toltsétek fel az oltás dátumát + 3 dátumma, kutyaként
        }
    }
}
