using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Exception Handling");
            Console.WriteLine("------ ArgumentException");
            Console.WriteLine(exampleArgumentException("Test", 7, 'a'));
            Console.WriteLine("------ OtherKindException");
            exampleOtherKindOfExceptions(43000, 410);
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
        static void exampleOtherKindOfExceptions(int x,int y)
        {
            try
            {
                if (x > 1000)
                { 
                    throw new ArgumentOutOfRangeException("x","x has to be 1000 or less");
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
            finally {
                Console.WriteLine("This code always runs");
            }
        }
    }
}