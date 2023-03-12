using System.Diagnostics.Metrics;

namespace Loops
{
    internal class Program
    {
        static int[] values = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------- Loops");
            Console.WriteLine("--------- While");
            WhileExample();
            Console.WriteLine("--------- Break");
            BreakExample();
            Console.WriteLine("--------- Continue");
            ContinueExample();
            Console.WriteLine("--------- Do While");
            DoWhilexample();
            Console.WriteLine("--------- For");
            ForExample();
            Console.WriteLine("--------- For Each ");
            ForEachExample("jota");
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
            foreach (int val in values)
            {
                if (val >= 20 && val <=29)
                {
                    continue;
                }
                Console.WriteLine($"Val is currently {val}");
            }
        }

        // Do while: Execute code first and then ckec the condition
        static void DoWhilexample()
        {
            int count = 0;
            do
            {
                Console.WriteLine("Fist iteration");
                count = 5;
            } while (count > 5);
        }
        static void ForExample()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        static void ForEachExample(string str)
        {
            // String is an array of chars
            foreach (char c in str)
            {
                Console.WriteLine($"Char: {c}");
            }
        }
    }
}