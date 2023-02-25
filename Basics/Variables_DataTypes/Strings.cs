using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes
{
    public class Strings
    {
        // Set default value
        string greeting { get; set; } = "      Hello World!       ";


        #region Trimmed and White spaces
        public void ShowWhiteSpaces()
        {
            Console.WriteLine($"[{greeting}]");
        }

        public void ShowtrimmedStartGreeting()
        {
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");
        }

        public void ShowtrimmedEndGreeting()
        {
            string trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");
        }

        public void ShowtrimmedGreeting()
        {
            string trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
        }
        #endregion

        #region Upper and Lower Case
        public void ShowUpperCaseGreeting()
        {
            Console.WriteLine($"[{greeting.ToUpper()}]");
        }

        public void ShowLowerCaseGreeting()
        {
            Console.WriteLine($"[{greeting.ToLower()}]");
        }
        #endregion

        #region Search text in string
        public bool IfContains()
        {
            return greeting.Contains("Hell");
        }
        public bool IfStartWith()
        {
            return greeting.StartsWith("Hell");
        }
        public bool IfEndWith()
        {
            return greeting.EndsWith("Hell");
        }
        #endregion
    }
}
