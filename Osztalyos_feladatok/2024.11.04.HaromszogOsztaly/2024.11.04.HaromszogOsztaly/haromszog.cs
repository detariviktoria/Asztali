using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._04.HaromszogOsztaly
{
    internal class Haromszog
    {
        // csak az értékét kérhessük le (get)
        //MEZŐK
        double a, b, c;

        //KONSTRUKTOR
        public Haromszog(double oldal1, double oldal2, double oldal3)
        {
            a = oldal1;
            b = oldal2;
            c = oldal3;
        }

        public Haromszog(string sor)
        {

            string[] s = sor.Split(';');
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
        }

        //METODUSOK
        // public mert kivülről is látom 
        public double A
        {
            get { return a; }
        }

        public double B
        {
            get { return b; }
        }
        public double C
        {
            get { return c; }
        }

        /*
         public double A {
            get;
            private set;
        }
         */

        public bool SzerkeszthetoE()
        {
            /*if(a+b>c && a+c>b && c+b>a)
            {
                return true;
            }
            else
                return false;*/
            return a + b > c && a + c > b && c + b > a;
        }

        public bool EgyenloSzaruE()
        {
            return a == b || a == c || b == c;
        }

        public bool SzabalyosE()
        {
            return a == b && a == c;
        }

        public double Kerulet()
        {
            return a + b + c;
        }

        public double Terulet()
        {
            double s = Kerulet() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public bool DerekszogE()
        {
            return (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b);
        }
    }
}
