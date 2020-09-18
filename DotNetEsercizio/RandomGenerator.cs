﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizio
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
           return random.Next(min, max);
        }
    }
}
