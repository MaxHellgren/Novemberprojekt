using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fighter1 : Fighter //Arv av metoden Fighter, eftersom jag vill att fighters ska ha olika stats
    {
        public Fighter1() //Lite konstigt, men det här är Alis stats, inte dina
        {                 //Eftersom att du tar damage från din egna metod, så måste statsen som damagen tas av vara från den andra fightern.
            minDamage = 5;
            maxDamage = 20;
            speed = 9;
            name = "";
        }
    }
}
