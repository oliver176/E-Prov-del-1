using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_del_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What hero do u want to be? 1: Batman 2: Superman 3: Spiderman");

            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int heroToPick); // parse stringen till en int, blir tru om den lýckas

            while (!success) // om input inte blir en inte så är du fast i loopen
            {
                if (!success)
                {
                    Console.WriteLine("Write a number!");
                }
                else if (heroToPick == 1)
                {
                    Superhero player = new Batman();
                }
                else if (heroToPick == 2)
                {
                    Superhero player = new Superman();
                }
                else if (heroToPick == 3)
                {
                    Superhero player = new Spiderman();
                }
                else if (heroToPick > 3 || heroToPick <= 0) //inåut måste bli inom den mängd hjältar som går attt välja mellan
                {
                    Console.WriteLine("Pick a number 1-3");
                    success = false;
                }
                
                input = Console.ReadLine();
                success = int.TryParse(input, out heroToPick);
            }

            Console.WriteLine("Now pick a name for your superhero!");

            

        }
    }
}
