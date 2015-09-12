using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


namespace DevisibleByThreeAndSeven
{
    class DevisibleBy3And7
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = new int[12] 
            {
                21, 31, 42, 43, 63, 64, 84, 95, 123, 105, 126, 127
            };
            var devisible = arrayOfInts.Where(ints => ints % 21 == 0);
            foreach (var item in devisible)
            {
                Console.WriteLine(item.ToString());
            }

            var devisibleWithLINQ =
                from ints in arrayOfInts
                where ints % 21 == 0
                select ints;

            foreach (var item in devisibleWithLINQ)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
