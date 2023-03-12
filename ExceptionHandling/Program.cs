using System.Diagnostics.CodeAnalysis;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(PadAndTrim("Test", 7, 'a'));
        }
        // PadLeft or Right complete the length requested with an specific char
        // Better retrieve String.Empty instead of use Concatenate ""
        static string PadAndTrim([AllowNull] string input, int length, char padChar)
        {
            if (input == null)
                return String.Empty.PadLeft(length, padChar);
            else if (input != null && input.Length <= length)
                return input.Trim().PadLeft(length, padChar);
            else
                throw new ArgumentException("Input is long thatn requested lenght");
        }
    }
}