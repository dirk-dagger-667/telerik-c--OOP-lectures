using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Test
    {
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>(){
                new Student("Dimitar", "Dimitrov", 10),
                new Student("Atanas", "Dimitrov", 12),
                new Student("Petar", "Dimitrov", 9),
                new Student("Boyan", "Dimitrov", 5),
                new Student("Petar", "Dimitrov", 5),
                new Student("Todor", "Dimitrov", 2),
                new Student("Danail", "Dimitrov", 1),
                new Student("Angel", "Dimitrov", 10),
                new Student("Emil", "Dimitrov", 13),
                new Student("Kiril", "Dimitrov", 7)
            };

            var sortedListOfStudents = listOfStudents.OrderBy(x => x.Grade);

            foreach (var student in sortedListOfStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }

            var listOfWorkers = new List<Worker>(){
                new Worker("Dimitar", "Dimitrov", 360, 38),
                new Worker("Atanas", "Dimitrov", 380, 38),
                new Worker("Todor", "Dimitrov", 360, 38),
                new Worker("Todor", "Dimitrov", 300, 38),
                new Worker("Petar", "Dimitrov", 280, 38),
                new Worker("Momchil", "Dimitrov", 400, 38),
                new Worker("Vidiu", "Dimitrov", 400, 38),
                new Worker("Krakra", "Dimitrov", 320, 38),
                new Worker("Bayan", "Dimitrov", 460, 38),
                new Worker("Rasate", "Dimitrov", 800, 38)
            };

            var sortedListOfWorkers = listOfWorkers.OrderByDescending(x => x.PaymentPerHour());

            foreach (var worker in sortedListOfWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.PaymentPerHour());
            }

            var mergerLists = new List<Human>(sortedListOfStudents.Count() + sortedListOfWorkers.Count());

            mergerLists.AddRange(sortedListOfStudents);
            mergerLists.AddRange(sortedListOfWorkers);

            var sortedMergerList = mergerLists.OrderBy(x => x.FirstName).ThenBy(y => y.LastName);

            foreach (var human in sortedMergerList)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
