using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndToString
{
    public class Test
    {
        public static void Main()
        {
            Person person = new Person("Dimitar Dimitrov", null);

            Console.WriteLine(person.ToString());
        }
    }
}
