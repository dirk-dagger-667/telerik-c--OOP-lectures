namespace FirstBeforeLastName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class NameFilter
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return FirstName + " " + LastName + " " + Age;
            }
        }
        static void Main(string[] args)
        {
            var listOfStudents = new List<Student>{
                new Student{FirstName = "Alex", LastName = "Urod", Age = 22},
                new Student{FirstName = "Petko", LastName = "Urod", Age = 14},
                new Student{FirstName = "Botio", LastName = "Alex", Age = 20},
                new Student{FirstName = "Kravar", LastName = "Atanasov", Age = 23}
            };

            //var newListOfStudents = listOfStudents.FindAll(x => x.FirstName[0] < x.LastName[0]);

            //for (int i = 0; i < newListOfStudents.Count; i++)
            //{
            //    Console.WriteLine(newListOfStudents[i]);
            //}

            //var newNewListOfStudents =
            //    from student in listOfStudents
            //    where student.FirstName[0] < student.LastName[0]
            //    select student;

            //foreach (var student in newListOfStudents)
            //{
            //    Console.WriteLine(student);
            //}

            //newListOfStudents = listOfStudents.FindAll(x => x.Age >= 18 && x.Age <= 25);

            //for (int i = 0; i < newListOfStudents.Count; i++)
            //{
            //    Console.WriteLine(newListOfStudents[i]);
            //}

            //newNewListOfStudents =
            //    from student in listOfStudents
            //    where student.Age >= 18 && student.Age <= 25
            //    select student;

            //foreach (var student in newNewListOfStudents)
            //{
            //    Console.WriteLine(student);
            //}

            //var newListOfStudents = listOfStudents.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            //foreach (var student in newListOfStudents)
            //{
            //    Console.WriteLine(student);
            //}

            //var newNewListOfStudents = (from student in listOfStudents
            //    select student).OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            //foreach (var student in newNewListOfStudents)
            //{
            //    Console.WriteLine(student);
            //}
        }
    }
}
