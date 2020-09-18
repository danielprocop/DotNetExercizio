using System;
using System.Collections.Generic;
using System.Text;


namespace DotNetEsercizio.Core
{
    public interface IRandomGenerator
    {
        int Next(int min, int max);
        int Next(int max);
        bool NextBoolean();
    }
}
