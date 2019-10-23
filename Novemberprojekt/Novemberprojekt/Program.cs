using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter1 f1 = new Fighter1(); //skapar instanser av de olika gubbarna
            Fighter2 f2 = new Fighter2();

            Console.WriteLine("Name of fighter 1?");
            f1.name = Console.ReadLine();
            Console.WriteLine("Name of fighter 2?");
            f2.name = Console.ReadLine();

            f1.Hurt();
        }
    }
}