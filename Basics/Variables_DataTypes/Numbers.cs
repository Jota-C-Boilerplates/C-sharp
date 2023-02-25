using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes
{
    public class Numbers
    {
        int a { get; set; }
        int b { get; set; }
        int c { get; set; }

        /*Teory
       The double numeric type represents a double-precision floating point number. Those terms may be new to you. 
       A floating point number is useful to represent non-integral numbers that may be very large or small in magnitude. 
       Double-precision is a relative term that describes the numbers of binary digits used to store the value. 
       Double precision numbers have twice the number of binary digits as single-precision. On modern computers, 
       it is more common to use double precision than single precision numbers. Single precision numbers are declared using the float keyword.*/
        double e { get; set; } = 1.520;
        double f { get; set; } = 17.15;
        /* The decimal type has a smaller range but greater precision than double. 
        * The M suffix on the numbers is how you indicate that a constant should use the decimal type. Otherwise, the compiler assumes the double type.*/
        decimal g { get; set; } = 1.520M;
        decimal h { get; set; } = 17.15M;


        #region Int - Basic math operations
        public int Addition()
        {
            return a + b + c;
        }
        public int Substraction()
        {
            return a - b - c;
        }
        public int Mutiplication()
        {
            return a * b * c;
        }
        public int Division()
        {
            return (a / b) / c;
        }
        public int Remainder()
        {
            return (a % b);
        }
        #endregion

        #region Limit type of variable
        public void GetIntLimits()
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");
        }
        public void UnderflowOrOverFlowInt()
        {
            int max = int.MaxValue;
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}"); // -2147483646
        }
        public void GetLimitsDouble()
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");
        }
        public void GetLimitsDecimal()
        {
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
        }
        #endregion
    }
}
