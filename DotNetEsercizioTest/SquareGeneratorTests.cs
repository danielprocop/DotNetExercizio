using DotNetEsercizio;
using DotNetEsercizioTest.Fakes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizioTest
{
    [TestFixture]
    public class SquareGeneratorTests
    {
        [Test]
        public void GenerateNewSquare_WhenCalled_ReturnNewSquare()
        {
            var fakeRandomGenerator = new FakeRandomGenerator(10);
            var squareGenerator = new SquareGenerator(fakeRandomGenerator);

            var square=squareGenerator.GenerateNewSquare();

            Assert.AreEqual(10, square.SideLength);
        }
    }
}
