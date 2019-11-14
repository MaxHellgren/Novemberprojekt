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

        public void Hurt() //Själva fightmetoden, kallas från GetHP()
        {			
            damage = gen.Next(minDamage, maxDamage); //Damage som outputas är ett värde mellan de 2 som fighter1/2 har i sina klasser
            int hit = gen.Next(1, 11); //Slumpar nummer mellan 1 och 10 som sedan jämförs med speed
            if (hit > speed) //Fighters har 6 och 9 som speed, om hit är mer än deras nummer så missar slaget och de gör ingen damage
            {
                miss = true;
                damage = 0;
                Console.WriteLine(name + " dodged the blow!"); //Eftersom du slår dig själv, så säger jag att du dodgear istället för att attacken missar,                                                               //för då blir det fel.
            }                                                  //för då blir det fel.

            else //Säger den här om slaget träffar
            {
                Console.WriteLine(name + " took " + damage + " damage."); //Skriver ut i konsollen hur mycket damage din fighter tog.
            }
        }

        public void GetHP() //ger fighters hp, som sedan subtraheras. 
        {
            Hurt(); //Eftersom att jag kallar GetHP i Fight så måste jag kalla hurt här
            HP = HP - damage;
            Console.WriteLine(name + " currently has " + HP + " HP remaining."); //Printar nuvarande HP efter du blivit träffad
            Console.WriteLine("");
        }

        public void IsAlive()
        {
            if (HP < 1) //När någon förlorar
            {
                Console.WriteLine("");
                Console.WriteLine(name + " has lost the fight!");//Behövs inte readline efter eftersom det finns ett efter f.GetHP i fightklassen
                
                alive = false; //Loopen i fight-klassen tar slut
            }
        }
    }
}
