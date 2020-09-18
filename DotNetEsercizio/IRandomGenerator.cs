using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetEsercizio
{
    public interface IRandomGenerator
    {
        int Next(int min, int max);
    }
}
