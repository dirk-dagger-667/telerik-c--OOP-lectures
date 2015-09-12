using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace SubStringForStringBuilder
{
    public static class TestClass
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            if (sb.Equals(null) == true)
            {
                throw new ArgumentNullException("StringBuilder cannot be null!");
            }
            else
            {
                StringBuilder subString = new StringBuilder();
                for (int i = index; i < length + index; i++)
                {
                    subString.Append(sb[i]);
                }
                return subString;
            }
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is the string that I want you to print only the substring of!");
            Console.WriteLine(sb.Substring(9, 12));
        }
    }
}
