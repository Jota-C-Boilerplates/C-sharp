namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enums
            var turnip = Enum_SomeRootVegetable.Turnip;

            var spring = EnumFlags_Seasons.Spring;
            var startingOnEquinox = EnumFlags_Seasons.Spring | EnumFlags_Seasons.Autumn;
            var theYear = EnumFlags_Seasons.All;

            Console.WriteLine($"Enums examples: turnip: {turnip} | spring: {spring} | startingOnEquinox: {startingOnEquinox} | theYear: {theYear}");

        }
    }
}