using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Switches
    {
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
    }
}
