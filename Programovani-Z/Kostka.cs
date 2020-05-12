using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programovani_Z
{
    class Kostka
    {
        private int PocetHran;
        private Random Random;

        public Kostka(int pocet)
        {
            PocetHran = pocet;
            Random = new Random();
        }

        public int HodKostkou()
        {
            return Random.Next(1, PocetHran + 1);
        }
    }
}
