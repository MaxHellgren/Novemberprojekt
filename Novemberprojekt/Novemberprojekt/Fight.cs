using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Fight //Saker som inte är så intensiv kod, kör saker från Fighter, finns mest för att Main() inte ska ha massa strunt
    {
        Fighter1 f1 = new Fighter1(); //skapar instanser av de olika gubbarna
        Fighter2 f2 = new Fighter2();

        public void Fights()
        {
            Console.WriteLine("What's your fighter's name?");
            f1.name = Console.ReadLine(); //Bestäm din fighters namn, andra är redan bestämt som Ali
            Console.Clear();

            Console.WriteLine("Welcome to the stands, ladies and gentlemen!");
            Console.WriteLine("Tonight's fight is between " + f1.name + " and " + f2.name + "!");
            Console.ReadKey();
            Console.Clear();


            int i = 0; //ökar varje runda för att räkna vilken runda fighten är på.
            while (f1.alive == true && f2.alive == true) //När en fighter dör tar metoden slut, och spelet slutar.
            {
                i++;
                Console.WriteLine("Round " + i + "!");
                Console.WriteLine("");
                f1.GetHP();   //GetHP attackerar och ändrar HP. 
                f1.IsAlive(); //Måste kolla isalive separat, för annars så tar ali damage när du redan har dött. Isåfall kan båda bli knockade samma runda,               
                              //vilket inte är logiskt i en ritig fight.

                if (f1.HP > 1) //Kollar så att f1 inte redan har dött, så båda inte kan dö samma runda
                {
                    f2.GetHP();
                    f2.IsAlive(); //Skulle annars bara kalla IsAlive efter varje GetHP
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
