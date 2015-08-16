using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeQuerry
{
    class SortingByAge
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new{ FirstName = "Bogomil", LastName = "Bonev", Age = 23},
                new{ FirstName = "Dimitar", LastName = "Dimitrov", Age = 17},
                new{ FirstName = "Atanas", LastName = "Atanasov", Age = 26}
            };

            var sortedByAge =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var item in sortedByAge)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
