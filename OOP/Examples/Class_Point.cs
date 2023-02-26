using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Class_Point
    {
        public int X { get; }
        public int Y { get; }

        // New way to define a constructor
        public Class_Point(int x, int y) => (X, Y) = (x, y);
    }
}
