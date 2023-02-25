using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes
{
    public class Object
    {
        public void ObjectConversion() {
            int i = 123;
            object o = i;    // Boxing
            int j = (int)o;  // Unboxing
            Console.WriteLine($"Object: {o}");
            Console.WriteLine($"Int: {j}");
        }
    }
}
