using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _2024._11._14._Static_Felhasznalasa
{
    internal class DatumIdo
    {
        /// <summary>
        /// Dátum értékéből kiszedi az év értékét.
        /// </summary>
        /// <param name="datum">
        ///     Formátuma:év * honap * nap
        ///     egykarakterből álló elválasztó
        ///     pl. 2024_11_14
        /// </param>
        /// <returns></returns>
        /// 

        public static int DatumEv(string datum)
        {
            char sc = datum[4];
            string[] strings = datum.Split(sc);
            return Convert.ToInt32(strings[0]); 
        }

        public static int DatumHonap(string datum)
        {
            char sc = datum[4];
            string[] strings = datum.Split(sc);
            return Convert.ToInt32(strings[1]);
        }
    

        public static bool SzokoevE(string datum)
        {
            char sc = datum[4];
            string[] strings = datum.Split(sc);
            if ((Convert.ToInt16(strings[0]) % 4 == 0 && Convert.ToInt16(strings[0]) % 100 != 0 ) || Convert.ToInt16(strings[0]) % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
