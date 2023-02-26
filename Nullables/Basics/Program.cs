namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable
            int? optionalInt = default;
            //optionalInt = 5;
            string? optionalText = default;
            optionalText = "Hello World.";
            Console.WriteLine($"optionalInt: {optionalInt} | optionalText: {optionalText} ");
        }
    }
}