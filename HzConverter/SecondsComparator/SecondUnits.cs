using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HzConverter.SecondsComparator
{
    public enum SecondUnits: long
    {
        Second = 1,
        Milisecond = 1_000,
        Microsecond = 1_000_000,
        Nanosecond = 1_000_000_000,
        Picosecond = 1_000_000_000_000
    }
}
