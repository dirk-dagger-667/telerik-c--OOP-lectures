//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
//Using delegates write a class Timer that has can execute certain method at each t seconds.

namespace DevisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void SimpleDelegate(int[] array);
    class ExtractorOfDivisibles
    {
        public static void PrintDivisibleByLambda(int[] array)
        {
            var newArray = array.Where(x => x % 7 == 0 && x % 3 == 0);

            foreach (var element in newArray)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintEverySecond(int[] array)
        {
            var simpleDelegate = new SimpleDelegate(PrintUsingLINQ);

            while (true)
            {
                simpleDelegate(array);
                System.Threading.Thread.Sleep(1000);
            }
        }
        public static void PrintUsingLINQ(int[] array)
        {
            var newArray =
                from element in array
                where element % 3 == 0 && element % 7 == 0
                select element;

            foreach (var element in newArray)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            var arrayOfInts = new int[]{7, 23, 21, 35, 70, 50, 123, 121};

            PrintDivisibleByLambda(arrayOfInts);
            PrintUsingLINQ(arrayOfInts);
        }
    }
}
