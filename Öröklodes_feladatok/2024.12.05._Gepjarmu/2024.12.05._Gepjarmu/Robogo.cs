using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._05._Gepjarmu

/* puha-csokis-gesztenyer%C3%BAd-s%C3%BCt%C3%A9s-n%C3%A9lk%C3%BCl-egy-pillanat-alatt-elfogy-a-t%C3%A1ny%C3%A9rr%C3%B3l/ar-AA1vvVN7?ocid=winp1taskbar&cvid=be6723775f6a4002f234fbf187714888&ei=15 */
/*3 karácsonyi édesség, amihez a sütőt sem kell bekapcsolnod: hagyományos recept és izgalmas újítás is van köztük*/
/*Brassói aprópecsenye csirkemellből: így lesz a legfinomabb a szaftja*/
/*Göngyölt csirkemell körtével töltve: a hús mellé is kerül a gyümölcsből*/
{
   internal class Robogo : Jarmu, IKisGepjarmu
   {
       private int maxsebesseg;

       public Robogo(string rendszam, int sebesseg, int maxsebesseg):base(sebesseg, rendszam)
       {
           this.maxsebesseg = maxsebesseg;
       }

       public override bool GyorshajtottE(int sebessegKorlat)
       {
           return sebesseg>sebessegKorlat;
       }

       public bool HaladhatItt(int s)
       {
           return maxsebesseg <= s;
       }

       public override string ToString()
       {
           return "Robogo: " + base.ToString();  // Az ősosztály toString metodus hasznalata
       }
   }
}
