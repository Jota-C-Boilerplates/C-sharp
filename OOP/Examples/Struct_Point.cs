using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public struct Struct_Point
    {
        public double X { get; }
        public double Y { get; }

        public Struct_Point(double x, double y) => (X, Y) = (x, y);
    }
}
