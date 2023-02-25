using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes
{
    public class DateTimes
    {
        public void DayofWeekEnum()
        {
            var day = DayOfWeek.Monday;
            Console.WriteLine(day);

            var wk2 = DateTime.Today.DayOfWeek;
            Console.WriteLine(wk2);
        }
    }
}
