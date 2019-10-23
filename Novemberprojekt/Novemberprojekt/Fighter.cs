using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    public class Fighter
    {
        public int minDamage; //min och maxdamge bestäms i separata fighters metoder med hjälp av arv
        public int maxDamage;
        public int speed;
        public int damage;
        public string name;

        public int Hurt(int damage)
        {
            Random gen = new Random();
            damage = gen.Next(minDamage, maxDamage); //Damage som outputas är ett värde mellan de 2 som min fighter1/2 har
            int hit = gen.Next(1, 11);
            if (hit > speed)
            {
                bool miss = true;
                damage = 0;
            }
            return damage;
        }

        public void PrintStats()
        {
            Console.WriteLine("My name is " + name + " and I do between " + minDamage + " and " + maxDamage + " damage.");
            Console.ReadLine();
        }
    }
}
