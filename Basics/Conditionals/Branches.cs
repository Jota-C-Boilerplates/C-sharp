using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Branches
    {
        int a { get; set; } = 5;
        int b { get; set; } = 3;

        // And (&&), Or (||) and Not (!) Operators
        public void ConditionalsExample1()
        {
            if ((a + b > 8) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        public void ConditionalsExample2(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("The first number is greater than the second");
            }
            else if (x < y)
            {
                Console.WriteLine("The first number is lower than the second");
            }
            else if (x == y)
            {
                Console.WriteLine("The first number is lower than the second");
            }
            else
            {
                Console.WriteLine("Invalid parameters");
            }
        }

        public void TernaryConditional(int x)
        {
            var result = x == 3 ? "Equals to 3" : "Other number than 3";
            Console.WriteLine(result);
        }

    }
}
