namespace StudentsAndEnumerationAndShit
{
    using System;
    class Test
    {
        static void Main(string[] args)
        {
            Student student = new Student("A", "B", "V", "123", "123", "123", "123", UniversityFacultySpecialty.Universities.UniversityOfSofia
                , UniversityFacultySpecialty.Faculties.History, UniversityFacultySpecialty.Specialties.Engineering);

            Student newStudent = (Student)student.Clone();

            newStudent.FirstNAme = "aasdasdasd";

            Console.WriteLine(student);
            Console.WriteLine(newStudent);
        }
    }
}
