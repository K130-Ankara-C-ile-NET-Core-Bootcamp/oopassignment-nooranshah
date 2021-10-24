using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment.Struct
{
    public struct MovementFactor
    {
        public int XFactor { get; set; }
        public int YFactor { get; set; }

        public MovementFactor(int xFactor, int yFactor)
        {
            XFactor = xFactor;
            YFactor = yFactor;
        }

    }
}
