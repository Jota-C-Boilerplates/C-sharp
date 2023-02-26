using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class InheritClass_Point3D : Class_Point
    {
        public int Z { get; set; }

        public InheritClass_Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
