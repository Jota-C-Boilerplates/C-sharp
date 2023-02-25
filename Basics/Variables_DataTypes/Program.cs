namespace Variables_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------- Objects");
            /*
             An identifier is a variable name. An identifier is a sequence of unicode characters without any whitespace.
             An identifier may be a C# reserved word, if it's prefixed by @. Using a reserved word as an identifier can be useful 
            when interacting with other languages.
             */
            Object @object = new Object();
            @object.ObjectConversion();
        }
    }
}