using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSortingByFirstName
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int facultyNumber;
        private string tel;
        private string email;
        private List<int> grades;
        private int groupNumber;
        private Group group;

        public Student(string firstName, string lastName, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.groupNumber = groupNumber;
        }
        public Student(string firstName, string lastName, int facultyNumber, string tel, string email, List<int> grades, int groupNumber,Group group)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.tel = tel;
            this.email = email;
            this.grades = grades;
            this.groupNumber = groupNumber;
            this.group = group;
        }
        public Student(string firstName, string lastName, int facultyNumber, string tel, string email, List<int> grades, int groupNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.facultyNumber = facultyNumber;
            this.tel = tel;
            this.email = email;
            this.grades = grades;
            this.groupNumber = groupNumber;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public List<int> Grades
        {
            get { return this.grades; }
            set { this.grades = value; }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Dimitar", "Dimitrov", 1021006, "02-123123123", "e-mail@abv.bg", new List<int> { 2, 3, 4, 5, 6, 6, 6 }, 1));
            listOfStudents.Add(new Student("Georgi", "Atanasov", 1021231, "056-123123123", "e-mail@email.com", new List<int> { 2, 3, 4, 5, 6, 6, 6 }, 2));
            listOfStudents.Add(new Student("Ivan", "Stoimenov", 1021231, "056-123123123", "e-mail@abv.bg", new List<int> { 2, 3, 4, 5, 6, 6, 6 }, 2));
            listOfStudents.Add(new Student("Atanas", "Dimitrov", 1021006, "02-123123123", "e-mail@email.com", new List<int> { 2, 3, 4, 5, 2, 6, 6 }, 2));
            listOfStudents.Add(new Student("Strahil", "Stoimenov", 1021231, "02-123123123", "e-mail@abv.bg", new List<int> { 2, 3, 4, 5, 6, 6, 
6 }, 1));
            var sortedStudents =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.groupNumber);
            }
            //10
            var sortedStudentsUsingLambdaFunctions = listOfStudents.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (var item in sortedStudentsUsingLambdaFunctions)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.groupNumber);
            }
            //11
            var studentsByAbvBg =
                from student in listOfStudents
                where student.Email.Substring(student.Email.Length - 6, 6) == "abv.bg"
                select student;

            foreach (var item in studentsByAbvBg)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Email);
            }
            //12
            var studentsBySofiaTel =
                from student in listOfStudents
                where student.Tel.Substring(0, 3) == "02-"
                select student;

            foreach (var item in studentsBySofiaTel)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Tel);
            }
            // 13
            var studentsWithHighestGrades =
                from student in listOfStudents
                where student.Grades.Contains(6)
                select new {FullName = student.FirstName + " " + student.LastName, Marks = student.Grades };

            foreach (var item in studentsWithHighestGrades)
            {
                Console.WriteLine(item.FullName);
                foreach (var grade in item.Marks)
                {
                    Console.WriteLine(grade.ToString());
                }
            }
            // 14
            var studentsWithTwoLowGrades = listOfStudents.Where(x => x.Grades.Count(m => m == (dynamic)2) == (dynamic)2);

            foreach (var item in studentsWithTwoLowGrades)
            {
                Console.WriteLine("{0}", item.FirstName);
                foreach (var grade in item.Grades)
                {
                    Console.WriteLine("{0}", grade);
                }
            }
            //15
            var enrolledIn2006 = listOfStudents.Where(student => student.FacultyNumber.ToString().Substring(5, 2) == "06");

            foreach (var item in enrolledIn2006)
            {
                Console.WriteLine();
                foreach (var grade in item.Grades)
                {
                    Console.Write(grade.ToString() + " ");
                }
            }
            Console.WriteLine();
            //16
            var listOfGroups = new[]
            {
                new Group(1, "Mathematics"),
                new Group(2, "Philosophy")
            };

            var mathematicians =
                from student in listOfStudents
                join departament in listOfGroups on student.GroupNumber equals departament.GroupNumber
                where departament.DepartamentName == "Mathematics"
                select student;

            foreach (var item in mathematicians)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            //18
            var newListOfGroups = new[]
            {
                new Group("Troll",1),
                new Group("Goblin",2)
            };

            var newListOfStudents = new[]
            {
                new Student("Tihomir", "Tihomirov", 1),
                new Student("Dimitar", "Dimitrov", 1),
                new Student("Stefan", "Stefanoc", 2),
                new Student("Boian", "Boianov", 2)
            };

            var groupedByGroupName =
                from student in newListOfStudents
                join someGroup in newListOfGroups on student.GroupNumber equals someGroup.GroupNumber
                select new {Name = student.FirstName + " " + student.LastName, someGroup.GroupName };

            foreach (var item in groupedByGroupName)
            {
                Console.WriteLine(item.Name + " " + item.GroupName);   
            }
            //19
            var groupedByUsingLambda = newListOfStudents.GroupJoin
                (newListOfGroups,
                student => student.GroupNumber,
                someGroup => someGroup.GroupNumber,
                (student, someGroups) => 
                    new { FirstName = student.FirstName + " " + student.LastName, 
                        GroupNumber = someGroups.Select(someGroup => someGroup.GroupName) });
            foreach (var item in groupedByUsingLambda)
            {
                Console.WriteLine("{0}", item.FirstName);
                foreach (var obj in item.GroupNumber)
                {
                    Console.WriteLine(" {0}", obj);
                }
            }
        }
    }
}
