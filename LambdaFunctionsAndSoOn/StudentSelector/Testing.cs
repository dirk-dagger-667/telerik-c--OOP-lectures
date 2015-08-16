namespace StudentSelector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Testing
    {
        static void Main(string[] args)
        {
            var listOfStudent = new List<Student>()
            {
                new Student{FirstName = "Dimitar",
                    LastName = "Dimitrov",
                    GroupNumber = 2,
                    Email = "dimitar.dimitrov@abv.bg",
                    Tel = "02-123-123",
                    Marks = new List<int> {6, 1, 2, 3, 4, 5},
                    FN = "123116",
                    Group = new Group {DepName = "Mathematics"}},
                new Student{FirstName = "Atanas",
                    LastName = "Dimitrov",
                    GroupNumber = 2,
                    Email = "atanas.dimitrov@yahoo.com",
                    Tel = "032-123-123",
                    Marks = new List<int> {6, 1, 2, 3, 4, 5},
                    FN = "123106",
                    Group = new Group {DepName = "Drama"}},
                new Student{FirstName = "Hristo",
                    LastName = "Dimitrov",
                    GroupNumber = 3,
                    Email = "hristo,dimitrov@abv.bg",
                    Tel = "02-123-123",
                    Marks = new List<int> {6, 1, 2, 3, 4, 5},
                    FN = "123106",
                    Group = new Group {DepName = "Drama"}},
                new Student{FirstName = "Konstantin",
                    LastName = "Dimitrov",
                    GroupNumber = 2,
                    Email = "konstantin@gmail.com",
                    Tel = "056-123-123",
                    Marks = new List<int> {2, 1, 2, 3, 4, 5},
                    FN = "123105",
                    Group = new Group {DepName = "Drama"}},
                new Student{FirstName = "Yavor",
                    LastName = "Dimitrov",
                    GroupNumber = 1,
                    Email = "yavor.dimitrov@yahoo.com",
                    Tel = "02-123-123-123",
                    Marks = new List<int> {2, 1, 2, 3, 4, 5},
                    FN = "123106",
                    Group = new Group {DepName = "Drama"}}
            };

            //This here is the LINQ
            //var newListOfOrderedStudentsFromGroup2 =
            //    from student in listOfStudent
            //    where student.GroupNumber == 2
            //    orderby student.FirstName
            //    select student;

            //This is using the Lambda Functions
            //var newListOfOrderedStudentsFromGroup2 = listOfStudent.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            //LINQ grouping of students with e-mails @abv.bg
            //var newListOfStudentsWithEmailsInABV =
            //    from student in listOfStudent
            //    where student.Email.Contains("abv.bg")
            //    select student;

            //Lambda grouping of students with e-mails @abv.bg
            //var newListOfStudentsWithEmailsInABV = listOfStudent.FindAll(x => x.Email.Contains("abv.bg"));

            //LINQ grouping of students with tels in Sofia
            //var listOfStudentFromSofia =
            //    from student in listOfStudent
            //    where student.Tel.StartsWith("02-")
            //    select student;

            //Lambda grouping of students with tels in Sofia
            //var listOfStudentsFromSofia = listOfStudent.FindAll(x => x.Tel.StartsWith("02-"));

            //foreach (var student in listOfStudentsFromSofia)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Tel);
            //}

            //13. LINQ
            //var listOfStudentsWithMark6 =
            //    from student in listOfStudent
            //    where student.Marks.Contains(6)
            //    select new { Fullname = student.FirstName + " " + student.LastName, Marks = student.Marks };

            //foreach (var student in listOfStudentsWithMark6)
            //{
            //    Console.WriteLine(student.Fullname);
            //}

            //13. LF
            //var listOfStudentsWithMark6 = listOfStudent.FindAll(x => x.Marks.Contains(6));

            //foreach (var student in listOfStudentsWithMark6)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.LastName);
            //}

            //14. LF
            //var listOfStudentsWith2Twos = listOfStudent.FindAll(x => x.Marks.Count(y => y == 2) == 2);

            //foreach (var student in listOfStudentsWith2Twos)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.LastName);
            //}

            //14. LINQ
            //var listOfStudentsWith2Twos =
            //    from student in listOfStudent
            //    where student.Marks.Count(x => x == 2) == 2
            //    select student;

            //foreach (var student in listOfStudentsWith2Twos)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.LastName);
            //}

            //15. LINQ
            //var listOfStudentOf2006 =
            //    from student in listOfStudent
            //    where student.FN.EndsWith("06")
            //    select student;

            //foreach (var student in listOfStudentOf2006)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.LastName);
            //}

            //15. LF
            //var listOfStudentOf2006 = listOfStudent.FindAll(x => x.FN.EndsWith("06"));

            //foreach (var student in listOfStudentOf2006)
            //{
            //    Console.WriteLine(student.FirstName + " " + student.LastName);
            //}
        }
    }
}
