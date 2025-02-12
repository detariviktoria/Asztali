using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._06._GyakorlasVerseny
{
    internal  class IFutas
    {
        /// <summary>
        /// Kezdes formatuma: ora:perc:sec
        /// </summary>
        DateTime Kezdes { get; set; }

        /// <summary>
        /// Befejezes formatuma: ora: perc: sec
        /// </summary>
        DateTime Befejezes { get; set; }

        /// <summary>
        /// Befejezes és kezdés különbsége
        /// </summary>
        /// <returns></returns>

        public (int, int) TeljesitmenyPercSec()
        {
            int perc = 0; 
            int sec = 0;


            //int[] k = Array.ConvertAll(Kezdes.Split(':'), Convert.ToInt32);
            //int[] b = Array.ConvertAll(Befejezes.Split(":"), Convert.ToInt32);
            int ido = (Befejezes.Hour - Kezdes.Hour) * 60 * 60 + (Befejezes.Minute - Kezdes.Minute) *60 + Befejezes.Second - Kezdes.Second; // másodperc összes
            perc = ido / 60; // ennyi perc 
            sec = ido - perc * 60;


            return (perc, sec);
        }
    }
}
