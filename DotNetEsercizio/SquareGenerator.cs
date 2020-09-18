using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizio
{
    public class SquareGenerator
    {
        private const int QMIN= 1;
        private const int QMAX= 10;
        private readonly IRandomGenerator _randomGenerator;
        public SquareGenerator(IRandomGenerator randomGenerator)
        {
            _randomGenerator = randomGenerator;
        }
        public Square GenerateNewSquare()
        {
            var random = new Random();
            var sideLength= _randomGenerator.Next(QMIN, QMAX + 1);
            return new Square(sideLength);
        }
    }
}
