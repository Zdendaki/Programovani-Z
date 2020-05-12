﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportka
{
    class RandomGenerator
    {
        Random Rand;

        public RandomGenerator()
        {
            Rand = new Random();
        }

        public string GenerateRound()
        {
            string output = string.Empty;
            HashSet<int> numbers = new HashSet<int>();

            while (numbers.Count < 6)
                numbers.Add(Rand.Next(1, 50));

            numbers = numbers.OrderBy(x => x).ToHashSet();

            foreach (int num in numbers)
            {
                output += $" {num:D2}";
            }

            return output;
        }

        public int GenerateChance()
        {
            return Rand.Next(100000, 1000000);
        }
    }
}
