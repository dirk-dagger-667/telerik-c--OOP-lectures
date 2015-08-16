namespace IEnumrableExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class IenumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> enumarable, IEnumerable<T> data1)
        {
            dynamic sum = default(T);

            foreach (var element in data1)
            {
                sum += element;
            }

            return sum;
        }

        public static T Multiply<T>(this IEnumerable<T> enumarable, IEnumerable<T> data1)
        {
            dynamic product = default(T);

            foreach (var element in data1)
            {
                product *= element;
            }

            return product;
        }

        public static T Max<T>(this IEnumerable<T> enumarable, IEnumerable<T> data1)
        {
            return data1.Max();
        }

        public static T Min<T>(this IEnumerable<T> enumarable, IEnumerable<T> data1)
        {
            return data1.Min();
        }

        public static T Average<T>(this IEnumerable<T> enumarable, IEnumerable<T> data1)
        {
            dynamic sum = default(T);

            foreach (var element in data1)
            {
                sum += element;
            }

            return sum / data1.Count();
        }

        static void Main(string[] args)
        {
        }
    }
}
