using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fighter2 : Fighter //Arv av metoden Fighter, eftersom jag vill att fighters ska ha olika stats
    {
        public Fighter2() //Lite konstigt, men det här är dina stats, inte Alis
        {                 //Eftersom att du tar damage från din egna metod, så måste statsen som damagen tas av vara från den andra fightern.
            minDamage = 10;
            maxDamage = 27;
            speed = 6;
            name = "Ali";
        }
    }
}
