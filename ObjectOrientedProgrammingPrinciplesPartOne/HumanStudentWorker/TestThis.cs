using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class TestThis
    {
        public static void Main()
        {
            var students = new List<Student>() 
            {
            new Student("Dimitar","Dimitrov", 12),
            new Student("Georgi", "Dimitrov", 9),
            new Student("Atanas", "Atanasov", 12),
            new Student("Petar", "Georgiev", 10),
            new Student("Ivan", "Atanasov", 1),
            new Student("Petko", "Petkov", 2),
            new Student("Vaklin", "Panikolov", 5),
            new Student("Vladimir", "Zamanov", 7),
            new Student("Strahil", "Nikolov", 7),
            new Student("Kaloian", "Karastoianov", 8)
            };

            var sortedStudents = students.OrderBy(student => student.Grade);
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Grade);
            }
            Console.WriteLine();

            var workers = new List<Worker>() 
            {
            new Worker("Galin","Martinov",182.00M, 5),
            new Worker("Martin","Marinov",130.00M, 5),
            new Worker("Gradimir","Dimitrov",112.00M, 5),
            new Worker("Stanimir","Sharanov",177.00M, 5),
            new Worker("Stanislav","Valchev",150.00M, 5),
            new Worker("Stefan","Atanasov",212.00M, 5),
            new Worker("Dimo","Chobanvv",190.00M, 5),
            new Worker("Damian","Ovcharov",170.00M, 5),
            new Worker("Anastas","Sokolov",160.00M, 5),
            new Worker("Pesho","Orlov",140.00M, 5)
            };

            var sortedWorkers = workers.OrderByDescending(worker => worker.ReturnMoneyPerHour());
            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.ReturnMoneyPerHour());
            }
            Console.WriteLine();

            var mergedList = students.Concat < Human > (workers).ToList();
            mergedList = mergedList.OrderBy(item => item.FirstName).ThenBy(item => item.LastName).ToList();

            foreach (var item in mergedList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
