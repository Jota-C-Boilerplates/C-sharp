namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            //Output:
            //Sum of 3 elements is 4.5.
        }
    }
}