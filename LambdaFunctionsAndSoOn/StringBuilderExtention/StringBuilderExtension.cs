//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


namespace StringBuilderExtention
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class StringBuilderExtension
    {
        public static StringBuilder SubString(this StringBuilder str, int index, int length)
        {
            if (index > str.Length || index < 0)
            {
                throw new IndexOutOfRangeException("indexer is out of bounds");
            }
            else if (length > str.Length || length < 0)
            {
                throw new ArgumentOutOfRangeException("length less than zero, or larger than the length of the string");
            }
            else
            {
                var newStringBuilder = new StringBuilder();

                for (int i = index; i < length; i++)
                {
                    newStringBuilder.Append(str[i]);
                }

                return newStringBuilder;
        
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
