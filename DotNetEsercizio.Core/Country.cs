using System;
using System.Collections.Generic;

namespace DotNetEsercizio.Core
{
    public class Country
    {
        private readonly IRandomGenerator _randomGenerator;
        public List<IShape> Shapes { get; private set; } = new List<IShape>();

        public Country(
            IRandomGenerator randomGenerator
            , int numberofSquares
            , int qmin
            , int qmax)
        {
            _randomGenerator = randomGenerator;
            for (int i = 0; i < numberofSquares; i++)
            {
                var length = _randomGenerator.Next(qmin, qmax);
                Shapes.Add(new Square(length));
            }
        }

        public Rectangle MeetTwoSquares()
        {
            var firstShape = FirstShape();
            var secondIndex = NextShape(firstShape);
            var sumForHeight = _randomGenerator.NextBoolean();


            var height = FindDimension(firstShape.Height, secondIndex.Height, sumForHeight);
            var width = FindDimension(firstShape.Width, secondIndex.Width, !sumForHeight);
            Rectangle rectangle = new Rectangle(height, width);
            return rectangle;


        }
        private IShape FirstShape()
        {
            var index = _randomGenerator.Next(Shapes.Count - 1);
            return Shapes[index];

        }
        private IShape NextShape(IShape previousShape)
        {
            var index = _randomGenerator.Next(Shapes.Count - 1);

            if (previousShape != Shapes[index])
            {
                return Shapes[index];
            }

            if (index == Shapes.Count - 1)
            {
                return Shapes[0];
            }
            else
            {
                return Shapes[index + 1];
            }
        }
        private int FindDimension(int firstValue, int secondValue, bool sumForHeight)
        {
            int newValue;
            if (sumForHeight)
            {
                newValue = firstValue + secondValue;
            }
            else
            {
                newValue = Math.Min(firstValue, secondValue);
            }

            return newValue;
        }
    }
}
