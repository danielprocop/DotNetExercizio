using DotNetEsercizio;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizioTest.Fakes
{
    public class FakeRandomGenerator : IRandomGenerator
    {
        public int ValueToGenerate { get; set; }
        public FakeRandomGenerator(int valueToGenerate)
        {
            ValueToGenerate = valueToGenerate;
        }
        public int Next(int min, int max)
        {
            return ValueToGenerate;
        }
    }
}
