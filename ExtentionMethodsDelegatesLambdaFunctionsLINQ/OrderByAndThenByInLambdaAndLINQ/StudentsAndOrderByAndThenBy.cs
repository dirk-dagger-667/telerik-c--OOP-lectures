using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAndThenByInLambdaAndLINQ
{
    class StudentsAndOrderByAndThenBy
    {
        static void Main(string[] args)
        {
            var students = new[] 
            {
                new {FirstName = "Atanas", LastName = "Bojilov"},
                new {FirstName = "Kristiqn", LastName = "Atanasov"},
                new {FirstName = "Boian", LastName = "Botev"}
            };

            var orderedNames = students.OrderByDescending( x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in orderedNames)
            {
                Console.WriteLine(item.ToString());
            }

            var orderedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var item in orderedStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
