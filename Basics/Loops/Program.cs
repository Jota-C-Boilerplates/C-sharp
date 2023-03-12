using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WhileExample();
            BreakExample();
            ContinueExample();
        }
        //While: Check the conditional and excecute the statement - Pre Check
        static void WhileExample()
        {
            int count = 0;
            while (count > 5)
            { 
                Console.WriteLine("Repeat this message while count is lower than 5 - Pre check before of each iteration");
                count++;
            }
        }

        // Break means stop the loop
        static void BreakExample()
        {
            Console.WriteLine($"Break example");
            foreach (int val in values)
            {
                Console.WriteLine($"Val is currently {val}");
                if (val >= 40) {
                    break;
                }
            }
        }

        // Continue means please skip this value fot the iteration in the loop
        static void ContinueExample()
        {
            Console.WriteLine($"Continue example");
            foreach (int val in values)
            {
                if (val >= 20 && val <=29)
                {
                    continue;
                }
                Console.WriteLine($"Val is currently {val}");
            }
        }
    }
}