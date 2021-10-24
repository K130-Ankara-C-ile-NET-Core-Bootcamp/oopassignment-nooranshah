using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Struct
{
    public struct Coordinates
    {
        public long X { get; set; }
        public long Y { get; set; }
        public Coordinates(long x, long y)
        {
            X = x;
            Y = y;

        }
    }
}
