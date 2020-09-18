using DotNetEsercizio.Core;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizio
{
    public class App
    {
        private readonly Settings _settings;
        private readonly IRandomGenerator _randomGenerator;
        public App(IRandomGenerator randomGenerator
            , IOptions<Settings> options)
        {
            this._settings = options.Value;
            _randomGenerator = randomGenerator;
        }

        public IRandomGenerator RandomGenerator { get; }

        public int Run()
        {
            Country country = new Country(
                 _randomGenerator
                , _settings.NumberOfSquares
                , _settings.QMIN
                , _settings.QMAX);
            country.Init();

            for (int i = 0; i < _settings.NumberOfDays; i++)
            {
                Console.Write(country.MeetTwoSquares().ToString());
                Console.Write("\n");
            }
            Console.ReadLine();
            return 0;
        }
    }
}
