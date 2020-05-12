using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programovani_Z
{
    class HelloWorld
    {
        public void Pozdrav(string jmeno, int pocet)
        {
            for (int i = 0; i < pocet; i++)
                Console.WriteLine($"Ahoj {jmeno}!");
        }

        public double TretiOdmocnina(double input)
        {
            return Math.Pow(input, 1 / 3.0);
        }
    }
}
