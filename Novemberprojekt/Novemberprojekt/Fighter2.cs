using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fighter2 : Fighter //Arv av metoden Fighter, eftersom jag vill att fighters ska ha olika stats
    {
        public Fighter2()
        {
            minDamage = 10;
            maxDamage = 27;
            speed = 6;
            name = "Mike";
        }
    }
}
