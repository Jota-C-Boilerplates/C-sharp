using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("--------------- Exception Handling");
            Console.WriteLine("------ ArgumentException");
            Console.WriteLine(exampleArgumentException("Test", 7, 'a'));
            Console.WriteLine("------ OtherKindException");
            exampleOtherKindOfExceptions(43000, 410);*/

            exampleNestedInLoop();
        }
        // PadLeft or Right complete the length requested with an specific char
        // Better retrieve String.Empty instead of use Concatenate ""
        static string exampleArgumentException([AllowNull] string input, int length, char padChar)
        {
            if (input == null)
                return String.Empty.PadLeft(length, padChar);
            else if (input != null && input.Length <= length)
                return input.Trim().PadLeft(length, padChar);
            else
                throw new ArgumentException("Input is long thatn requested lenght");
        }
        static void exampleOtherKindOfExceptions(int x, int y)
        {
            try
            {
                if (x > 1000)
                {
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }
                int result = x / y;
                Console.WriteLine($"The result is: {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DividebyZero?");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Sorry, 1000 is the limit");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This code always runs");
            }
        }
        static void exampleNestedInLoop()
        {
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };


            for (int j = 0; j < number.Length; j++)
            {
                try
                {
                    Console.WriteLine("Code starts");
                    try
                    {
                        Console.WriteLine("Number: " + number[j] +
                                          "\nDivisor: " + divisor[j] +
                                          "\nQuotient: " + number[j] / divisor[j]);
                    }
                    // Catch block for inner try block
                    catch (Exception ex)
                    {
                        Console.WriteLine("Inner Try Catch Block" + ex.Message);
                        // throw; // Forzamos detener el programa.
                        // Great cuando ya no pongo el throw la exception se contra y continua sin que llame al Catch principal
                    }
                    Console.WriteLine("Continue in the loop");
                    Console.WriteLine("Finished --------------------------------------------");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Outer Try Catch Block"+ ex.Message);
                }
            }
        }
    }
}