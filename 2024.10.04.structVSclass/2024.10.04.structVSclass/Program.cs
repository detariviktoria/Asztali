using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2024._10._04.structVSclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Astruct st = new Astruct(23);
            Aclass cl = new Aclass(24);

            Console.WriteLine(st.ToString());
            Console.WriteLine(cl.ToString());

            Console.ReadLine();
        }

        static void Nullaz(Astruct v)
        {
            v.a = 8;
        }
    }

    struct Astruct
    {
        public int a;

        public Astruct(int a) { this.a = a; }

        public override string ToString()
        {
            return "szam: "+a;
        }
    }

    class Aclass
    {
        public int a;

        public Aclass(int a) { this.a = a; }

        public override string ToString()
        {
            return "szam: " + a;
        }
    }
}
