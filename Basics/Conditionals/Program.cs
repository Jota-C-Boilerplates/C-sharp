namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- Swith examples");
            Switches exampleSwith = new Switches();
            Console.WriteLine("----- Switch grouping");
            exampleSwith.SwitchGroupingWhen();
            Console.WriteLine("----- Switch return");
            Console.WriteLine(exampleSwith.returnExample(null, 4, 'j'));
            Console.WriteLine("----- Switch expression (C# 8)");
            exampleSwith.switchExpression();
            Console.WriteLine("----- Switch expression example 2 (C# 8)");


        }
    }
}