using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fight
    {
        private int HP;
        public string name;
        public Random gen = new Random();
        private int damage;
        private bool alive = true;

        public Fight()
        {
            while (this.alive == true)
            {
                Hurt();
            }
        }

        public int Attack(int damage)
        {
            damage = gen.Next(1, 21);

            return damage;
        }

        public void Hurt()
        {
            int damageTaken = Attack(damage);
            int hp = GetHp(HP);
            Console.WriteLine(name + " took " + this.damage + " damage and now has this much remaining HP: " + hp);
            Console.ReadLine();
        }

        public bool IsAlive(bool alive)
        {
            int hp = GetHp(HP);
            if (hp > 0)
            {
                alive = true;
            }
            else
            {
                alive = false;
                Console.WriteLine(name + " has died fighting in the ring!");
                Console.ReadLine();
            }

            return alive;
        }

        public int GetHp(int HP)
        {
            HP = HP - Attack(damage);

            return HP;
        }

    }
}
