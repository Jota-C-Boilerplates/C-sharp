namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Implicit conversion");
            int integerNumber = 11;
            long longNumber = integerNumber;
            Console.WriteLine($"Show long implicitly convert from and integer {longNumber}");
            Console.WriteLine("--------------- Explicit conversion or casting");
            /*  Casting is taking an object and attempting to "force" it to change types. When a cast
                is attempted, if the value of the Object is allowable in the new type. the Object Will
                casted into an object of the specified */
            float longNumber2 = (float)longNumber;
            Console.WriteLine("--------------- Parsing conversion");
            /* As mentioned earlier. the string type has a unique place among the primitive
                types. Because it is a reference type, it needs special handling when converting from
                it to other types. We call this parsing.
                The .NET Framework provides us with Parse() and Tryparse() methods on each
                primitive type to handle converting from a string to that type. How ever if the string cannot be parsed
                to an acceptable value for the target type, the Parse() method will throw an exception */
            string decString = "5.632";
            decimal decNumber = decimal.Parse(decString);
            Console.WriteLine("--------------- Conversion");
            /* A conversion is similar to a cast in that it takes a value of a particular type and
                changes it into a value of another type. However, conversions are more forgiving
                than casts, generally do not lose precision, and take computationally longer to
                execute.*/
            decimal myMoney = 5.67M;
            int intMoney = Convert.ToInt32(myMoney); // Value is now 6, so decimal value was rounded.

            Console.WriteLine("--------------- Try Parse");
            string input="25";
            int output;
            bool result = Int32.TryParse(input, out output);
            Console.WriteLine($"Parsing result {result}");
        }
    }
}