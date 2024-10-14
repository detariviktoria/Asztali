using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_19_Gyakorlas
{
    internal class Program
    {
        List<string> nevek = new List<string>() {
            "Farkas Máté",
            "Deák Zsombor",
            "Kakuk Ákos",
            "Kis Levente",
            "Varga Csaba",
            "Pálinkás Zoltán",
            "Détári Viktória",
            "Gebhardt Lilla",
            "Sebella Máté",
            "Zsidákovits Bálint",
            "Szabó Dániel"
        };

        static void Main(string[] args)
        {
            /* Hozzon létre egy struktúrát, amiben eltárolja a csoport neveit és mindenknek generál egy 18 számjegyből álló kódot! Ezektet a példányosítás során, adja is át!
             * A struktúrában legyenek a további mezők is:
             * Magasság, szemuveges, azonosító, jelszó.
             * A példányosítás során fusson le egy véletlen generálás, ami megadja a magassag [160,190] között. Illetve véletlen szerűen állítsa be, hogy szemüveges-e az illető.
             * Majd ugyen itt a példány elkészülése során, fusson le a struktúrában elkészített két függvény, az egyik eredménye az azonosító a másik a jelszó!
             * Azonosító: minden páratlanadik karakter kis betűvel, szóköz nélkül! és a kód számjegyeinek összege!
             * Jelszó: A kód kettesével vett értékének asci kódjából előállított betű! Ha 32-nél kisebb az érték, adjon hozzá 50-et!
             * CSináljon ToString metódust!*/
            Console.ReadLine();
        }

        struct Csoport
        {
            public string nev,jelszo, kod, id;
            public int magassag;
            public bool szemuveg;

            public Csoport(string nev, string kod) : this()
            {
                Random r = new Random();
                this.nev = nev;
                magassag = r.Next(160,191);
                /*if (r.Next(2) == 0)
                    szemuveg = true;
                else
                    szemuveg = false;*/
                szemuveg = r.Next(2) == 0;
                id = IdGeneralas(nev);
                this.kod = kod;
                jelszo = JelszoGeneralas();
            }

            private string IdGeneralas(string szoveg)
            {
                // Kis Pista -> KisPista -> Ksit -> ksit
                // 123456789123456789 -> 90
                // ksit90
                string szokoznelkuli = Szokoztelenites(szoveg);
                string paratlanbetuk = Rovidites(szokoznelkuli);
                int szamjegyekOsszege = SzamjegyekOsszeadasa(kod);
                string a = (paratlanbetuk) + (szamjegyekOsszege);
                return a;
            }



            private int SzamjegyekOsszeadasa(string k)
            {
                int sz = 0;
                for(int i = 0; i< k.Length; i++)
                {
                    sz += Convert.ToInt16(k[i]);
                }
                return sz;
            }
            private string Rovidites(string sz)
            {
                string ujnev = "";
                for (int j = 0; j < sz.Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        ujnev += sz[j];
                    }
                }
                return ujnev.ToLower();
            }

            private string Szokoztelenites(string sz)
            {
                string ujnev = "";
                for (int i = 0; i < sz.Length; i++)
                {
                    if (sz[i] != ' ')
                    {
                        ujnev += sz[i];
                    }
                }
                return sz;
            }

            private string JelszoGeneralas()
            {
                string jelszo = "";
                for (int i = 0;i< kod.Length; i++)
                {
                    int a = Convert.ToInt32(""+kod[i] + kod[i+1]);
                }
                return jelszo;
            }
        }
    }
}
