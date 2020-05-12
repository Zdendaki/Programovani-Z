using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sportka";
            RandomGenerator generator = new RandomGenerator();

            while (true)
            {
                Console.Write("Zadej počet polí: ");
                string vstup = Console.ReadLine();

                if (int.TryParse(vstup, out int pocet))
                {
                    if (pocet > 100)
                        pocet = 100;
                    else if (pocet < 1)
                        pocet = 1;

                    Console.WriteLine("------------------------");

                    for (int i = 0; i < pocet; i++)
                    {
                        Console.WriteLine($"{(i + 1),3}: {generator.GenerateRound()}");
                    }

                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Kód šance: {generator.GenerateChance()}");
                }
                else
                {
                    Console.WriteLine("Nezadal jste platné číslo.");
                }

                Console.Write("Chcete pokračovat? A/N ");

                if (Console.ReadKey().Key != ConsoleKey.A)
                    break;
                else
                    Console.Clear();
            }
        }
    }
}
