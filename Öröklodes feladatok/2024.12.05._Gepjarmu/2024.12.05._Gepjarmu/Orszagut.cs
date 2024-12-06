using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._05._Gepjarmu
{
    internal class Orszagut
    {
        static List<Jarmu> jarmuvek = new List<Jarmu>();

        public static void JarmuvekJonnek(string path)
        {
            StreamReader sr = new StreamReader(path);

            while (!sr.EndOfStream)
            {
                string[] st = sr.ReadLine().Split(' ');
                if (st[0] == "Robogo")
                {
                    Robogo r = new Robogo(st[0], Convert.ToInt32(st[1]), Convert.ToInt32(st[2]));
                    jarmuvek.Add(r);
                }
                else
                {
                    AudiS8 a = new AudiS8(st[0], Convert.ToInt32(st[1]), Convert.ToBoolean(st[2]));
                    jarmuvek.Add(a);
                }
            }

            sr.Close();
        }

        public static void KiketMertunkBe()
        {
            StreamWriter sw = new StreamWriter("buntetes.txt");

            for (int i = 0; i < jarmuvek.Count; i++)
            {
                if (jarmuvek[i].GetType() == typeof(AudiS8))
                    if (jarmuvek[i].GyorshajtottE(90))
                    {
                        sw.WriteLine(jarmuvek[i].ToString() + "Nem hajtott túl gyorsan");
                    }
                    else
                    {
                        sw.WriteLine(jarmuvek[i].ToString() + "Túlhajtott");
                    }
                else
                {
                    if (jarmuvek[i].HaladhatItt(90))
                    {
                        sw.WriteLine(jarmuvek[i].ToString() + "Haladhat itt");
                    }
                    else
                    {
                        sw.WriteLine(jarmuvek[i].ToString() + "Nem haladhat itt");
                    }
                }
            }

            sw.Close();
        }
    }
}
