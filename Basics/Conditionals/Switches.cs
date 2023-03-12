using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Switches
    {
        //Since C# 7 we can use any kind of expresion but not null values (bool, character, string, enumerations.)
        //If need more than 3 if statements, use Switch.
        public void SwitchDayOfWeek()
        {
            // Using Enum DayOfWeek
            var dayOfWeek1 = DateTime.Now.DayOfWeek;
            switch (dayOfWeek1)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Does somebody have a case of the Mondays?");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Friday");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Saturyday");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Holiday");
                    break;

            }
        }

        public void SwitchGroupingWhen()
        {
            int hourDay = DateTime.Now.Hour;
            var dayOfWeek1 = DateTime.Now.DayOfWeek;
            switch (dayOfWeek1)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday when hourDay < 16:
                    Console.WriteLine("Working time");
                    break;
                case DayOfWeek.Friday when hourDay >= 16:
                    Console.WriteLine("Weekend stards");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Relaxing on weekends");
                    break;
            }
        }

        // No always we need to put a break, we can replace for a return statement. 
        public string returnExample([AllowNull] string input, int length, char padChar)
        {
            if (input == null)
            {
                return String.Empty.PadLeft(length, padChar);
            }
            else if (input != null && input.Length <= length)
            {
                switch (padChar)
                {
                    case ' ':
                    case '|':
                        return input.Trim().PadLeft(length, padChar);
                    case '0':
                    case '9':
                        return input.Trim().PadRight(length, padChar);
                    default:
                        Console.WriteLine("No match found for pad character");
                        break;
                }
                return input.Trim().PadLeft(length, padChar);
            }
            else
                return "Other case";
        }

        // Switch expression: Since C#8, using arrow expresion, no more case and break commands.
        // Other structure but same result
        public void switchExpression()
        { 
            var dayOfWeek = DateTime.Now.DayOfWeek;
            var message = dayOfWeek switch
            {
                DayOfWeek.Monday => "Monday switch expression",
                DayOfWeek.Friday => "Friday switch expression",
                DayOfWeek.Sunday => "Sunday switch expression",
                _ => "Default statement"
            };
            Console.WriteLine(message);
        }
    }
}
