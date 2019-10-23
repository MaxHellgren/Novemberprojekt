using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fighter1 : Fighter //Arv av metoden Fighter, eftersom jag vill att fighters ska ha olika stats
    {
        public Fighter1()
        {
            minDamage = 5;
            maxDamage = 20;
            speed = 9;
            name = "Ali";
        }
    }
}
