using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.


namespace GroupFunctions
{
    public static class ExtensionForIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> enumerable)
        {
            dynamic sum = default(T);
            foreach (var item in enumerable)
            {
                sum += item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> enumarable)
        {
            dynamic product = default(T);
            foreach (var item in enumarable)
            {
                product *= item;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> enumarable)
        {
            dynamic min = enumarable.ElementAt(0);
            foreach (var item in enumarable)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> enumarable)
        {
            dynamic max = enumarable.ElementAt(0);
            foreach (var item in enumarable)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> enumarable)
        {
            dynamic sum = default(T);
            foreach (var item in enumarable)
            {
                sum += item;
            }
            return sum/enumarable.Count();
        }

        static void Main(string[] args)
        {
            string[] stringSomething = new string[] {"A", "B", "C" };
            int[] sum = new int[] {1,2,3,4,5,6,7 };
            Console.WriteLine(stringSomething.Sum());
            Console.WriteLine(sum.Sum());
        }
    }
}
