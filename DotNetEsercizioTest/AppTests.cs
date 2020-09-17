using DotNetEsercizio;
using NUnit.Framework;

namespace Tests
{
    public class AppTests
    {

        [Test]
        public void App_CanRun()
        {
            App app = new App();

            var value=app.Run();

            Assert.AreEqual(0,value);
        }
    }
}