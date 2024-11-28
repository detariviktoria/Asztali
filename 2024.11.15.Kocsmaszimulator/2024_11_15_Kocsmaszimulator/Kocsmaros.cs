using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_15_Kocsmaszimulator
{
    internal class Kocsmaros
    {
        // dolgozat: private public hasznalata, getter: csak visszaadja, setter: változtathatom
        /* olyan változo amibe vannak stringek mint bankszámlák get: engedem hogy globálisan barmikor elérjék, de nem változtahatom csak osztalyszinten belül 
         metodusok public private kulonbség
        toString overriddal 
        static használata */
        
        //Adattagok
        private int penz; 
        public static int koszospohar;

        public string Nev {
            get; //Kívülről lekérhető, 
            private set;// de csak osztályszinten változtatható
        }

        public int Penz
        {
            get { return penz; }
            set { penz = value; }
        }

        //Konstruktor
        public Kocsmaros(int penz)
        {
            this.penz = penz;
        }

        //Metódusok
        public void Elmos()
        {
            if (koszospohar > 0)
            {
                koszospohar--;
                Console.WriteLine("Egy koszos pohár elmosva.");
            }
            else
                Console.WriteLine("Nincs koszos pohár.");
        }
        public override string ToString()
        {
            return $"Kocsmáros pénze: {penz} Koszos poharak száma: {koszospohar}";
        }
    }
}
