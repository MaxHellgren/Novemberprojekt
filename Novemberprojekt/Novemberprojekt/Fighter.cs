using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    public class Fighter
    {
        public Random gen = new Random();
        protected int speed;
        public int damage;
        public string name;
        public bool miss;
        protected int minDamage; //min och maxdamge bestäms i separata fighters metoder med hjälp av arv
        protected int maxDamage;
        public bool alive = true;
        public int HP = 100;

        public void Hurt()
        {			
            damage = gen.Next(minDamage, maxDamage); //Damage som outputas är ett värde mellan de 2 som min fighter1/2 har
            int hit = gen.Next(1, 11); //Slumpar nummer mellan 1 och 10 som sedan jämförs med speed
            if (hit > speed) //Fighters har 6 och 9 som speed, om det är mer än deras nummer så missar slaget och de gör ingen damage
            {
                miss = true;
                damage = 0;
            }

            if (damage == 0) //Om du missar så säger announcern det
            {
                Console.WriteLine("He missed!");
            }
            else
            {
                Console.WriteLine(name + " took " + damage + " damage."); //Skriver ut i konsollen hur mycket damage din fighter tog.
            }
            Console.ReadLine();
        }

        public void GetHP() //ger fighters hp, som sedan subtraheras. 
        {
            Hurt();
            Console.WriteLine(name + " currently has " + HP + " HP remaining."); //Printar nuvarande HP
            HP = HP - damage;

            IsAlive();
        }

        public void IsAlive()
        {
            if (HP < 1)
            {
                Console.WriteLine(name + " has lost the fight!");
                Console.ReadLine();
                alive = false;
            }
        }
    }
}
