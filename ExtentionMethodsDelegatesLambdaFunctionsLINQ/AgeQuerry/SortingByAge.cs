using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.


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
