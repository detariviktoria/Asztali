using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._11._28._Absztrakt
{
    internal abstract class Tervrajz
    {
        public double szelesseg { get; protected set; }
        public double hossz { get; protected set; }

        public void HazElhelyeseTelken(int x, int y)
        {
            // Ház elhelyezese
        }

        public abstract void TeraszElhelyezese(int x, int y, int sz, int h);


    }
}
