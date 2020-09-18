using DotNetEsercizio;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizioTest
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void NewSquare_WhenCalled_CreateSquare()
        {
            Square square = new Square(4);

            Assert.NotNull(square);
            Assert.AreEqual(4, square.SideLength);
        }
    }
}
