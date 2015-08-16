using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLength
{
    class Lenghter
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = new string[] {"123", "hahahahaha", "1", "lalala" };

            //var lengthiestString =
            //    (from stringg in arrayOfStrings
            //    orderby stringg.Length descending
            //    select stringg).ElementAt(0);

            //Console.WriteLine(lengthiestString);

            var lengthiestString = arrayOfStrings.Aggregate("",(max, current) => max.Length > current.Length ? max : current);

            Console.WriteLine(lengthiestString);
        }
    }
}
