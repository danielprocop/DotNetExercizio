using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizio.Core
{
    public class RandomGenerator : IRandomGenerator
    {
        private readonly Random random;
        public RandomGenerator()
        {
            random = new Random();
        }
        public int Next(int min, int max)
        {
           return random.Next(min, max+1);
        }
        public int Next(int max)
        {
            return random.Next(max + 1);
        }
        public bool NextBoolean()
        {
            return random.NextDouble() >= 0.5;
        }
    }
}
