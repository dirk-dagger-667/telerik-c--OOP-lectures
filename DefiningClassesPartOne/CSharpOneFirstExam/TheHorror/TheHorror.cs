using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHorror
{
    class TheHorror
    {
        static void Main(string[] args)
        {

            string numberInput = Console.ReadLine().Trim('-');
            
            int counter = 0;
            
            char[] allDigits = numberInput.ToCharArray();
            //Array.Reverse(allDigits);
            int sumOfOddDigits = 0;
            for (int i = 0; i < allDigits.Length; i++)
            {
                
                if (i % 2 == 0)
                {
                    sumOfOddDigits += allDigits[i] - '0';
                    counter++;
                }
            }
         
            
                Console.WriteLine("{0} {1}", counter, sumOfOddDigits);
           



        }
    }
}
