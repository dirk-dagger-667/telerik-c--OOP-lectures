using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringWithMaximumLenght
{
    class MaximumLength
    {
        static string maxLengthString = string.Empty;
        static bool CompareValues(string someString)
        {
            if (maxLengthString.Length < someString.Length)
            {
                maxLengthString = someString;
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            string[] arrayOfStrings = { "ratatatata", "dog", "cat", "car", "blue", "green", "yellow" };

            var longestString =
                from someString1 in arrayOfStrings
                where CompareValues(someString1)
                select someString1;

            Console.WriteLine(longestString.Last());
        }
    }
}
