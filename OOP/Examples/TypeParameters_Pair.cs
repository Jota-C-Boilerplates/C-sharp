using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    // Generic classes define type parameters.
    public class TypeParameters_Pair<TFirst, TSecond>
    {
        public TFirst First { get; }
        public TSecond Second { get; }

        public TypeParameters_Pair(TFirst first, TSecond second) =>
            (First, Second) = (first, second);
    }
}
