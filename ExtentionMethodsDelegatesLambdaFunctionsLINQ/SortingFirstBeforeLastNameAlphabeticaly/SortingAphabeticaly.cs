using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.


namespace SortingFirstBeforeLastNameAlphabeticaly
{
    class SortingAphabeticaly
    {
        static void Main(string[] args)
        {
            var students = new[] 
            {
                new{ FirstName = "Georgi", LastName = "Nikolov"},
                new{ FirstName = "Nikola", LastName = "Georgiev"},
                new{ FirstName = "Atanas", LastName = "Pandolov"}
            };

            var sortedStudent =
                from student in students
                where student.FirstName[0] < student.LastName[0]
                select student;

            foreach (var item in sortedStudent)
            {
                Console.WriteLine(item);
            }
        }
    }
}
