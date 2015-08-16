namespace StudentsAndEnumerationAndShit
{
    using System;
    using System.Text;
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private string SSN;
        private string permanentAdress;
        private string mobileEmail;
        private string course;
        private UniversityFacultySpecialty.Universities university;
        private UniversityFacultySpecialty.Faculties faculty;
        private UniversityFacultySpecialty.Specialties specialty;

        public Student(string firstName, string secondName, string lastName, string SSN, string permanentAdress, string mobileEmail,
            string course, UniversityFacultySpecialty.Universities university, UniversityFacultySpecialty.Faculties faculty,
            UniversityFacultySpecialty.Specialties specialty)
        {
            this.FirstNAme = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.SSN = SSN;
            this.PermanentAdress = permanentAdress;
            this.MobileEmail = mobileEmail;
            this.Course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstNAme
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the first name cannot be neither null, nor empty");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string SecondNAme
        {
            get
            {
                return this.secondName;
            }
            private set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the second name cannot be neither null, nor empty");
                }
                else
                {
                    this.secondName = value;
                }
            }
        }
        public string LastNAme
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the last name cannot be neither null, nor empty");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public string SSNprop
        {
            get
            {
                return this.SSN;
            }
            private set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the SSN cannot be neither null, nor empty");
                }
                else
                {
                    this.SSN = value;
                }
            }
        }
        public string PermanentAdress
        {
            get
            {
                return this.permanentAdress;
            }
            private set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the permanent adress cannot be neither null, nor empty");
                }
                else
                {
                    this.permanentAdress = value;
                }
            }
        }
        public string MobileEmail
        {
            get
            {
                return this.mobileEmail;
            }
            private set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the mobile e-mail cannot be neither null, nor empty");
                }
                else
                {
                    this.mobileEmail = value;
                }
            }
        }
        public string Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                if (value == null && value == String.Empty)
                {
                    throw new ArgumentNullException("the course cannot be neither null, nor empty");
                }
                else
                {
                    this.course = value;
                }
            }
        }
        public UniversityFacultySpecialty.Universities University
        {
            get;
            set;
        }
        public UniversityFacultySpecialty.Faculties Faculty
        {
            get;
            set;
        }
        public UniversityFacultySpecialty.Specialties Specialty
        {
            get;
            set;
        }

        public override bool Equals(object someStudent)
        {
            if (someStudent == null)
            {
                return false;
            }

            Student student = someStudent as Student;

            if (this.firstName != student.firstName)
            {
                return false;
            }
            else if (this.secondName != student.secondName)
            {
                return false;
            }
            else if (this.lastName != student.lastName)
            {
                return false;
            }
            else if (this.SSN != student.SSN)
            {
                return false;
            }
            else if (this.permanentAdress != student.permanentAdress)
            {
                return false;
            }
            else if (this.mobileEmail != student.mobileEmail)
            {
                return false;
            }
            else if (this.course != student.course)
            {
                return false;
            }
            else if (this.specialty != student.specialty)
            {
                return false;
            }
            else if (this.university != student.university)
            {
                return false;
            }
            else if (this.faculty != student.faculty)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            return studentOne.Equals(studentTwo);
        }
        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return !studentOne.Equals(studentTwo);
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.secondName.GetHashCode() ^ this.lastName.GetHashCode();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("First Name : " + this.firstName + "\r\n" +
                "Second Name : " + this.secondName + "\r\n" +
                "Last Name : " + this.lastName + "\r\n" +
                "SSN : " + this.SSN + "\r\n" +
                "Permanent Adress : " + this.permanentAdress + "\r\n" +
                "Mobile E-mail : " + this.mobileEmail + "\r\n" +
                "Course : " + this.course + "\r\n" +
                "University : " + this.university.ToString() + "\r\n" +
                "Faculty : " + this.faculty + "\r\n" +
                "Specialty : " + this.specialty + "\r\n");

            return result.ToString();
        }

        public object Clone()
        {
            return new Student(this.firstName, this.secondName, this.lastName, this.SSN, this.permanentAdress, this.mobileEmail,
            this.course, this.university, this.faculty, this.specialty);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstNAme.Length > other.FirstNAme.Length)
            {
                for (int i = 0; i < other.FirstNAme.Length; i++)
                {
                    if (this.FirstNAme[i] > other.FirstNAme[i])
                    {
                        return 1;
                    }
                    else if (this.FirstNAme[i] == other.FirstNAme[i])
                    {
                        continue;
                    }
                    else
                    {
                        return -1;
                    }
                }

                return 1;
            }
            else
            {
                for (int i = 0; i < this.FirstNAme.Length; i++)
                {
                    if (i == this.FirstNAme.Length - 1 && this.FirstNAme.Length == other.FirstNAme.Length)
                    {
                        //TO DO for the comparing of the strings by SSN
                    }

                    if (this.FirstNAme[i] > other.FirstNAme[i])
                    {
                        return 1;
                    }
                    else if (this.FirstNAme[i] == other.FirstNAme[i] && i < this.FirstNAme.Length - 1)
                    {
                        continue;
                    }
                    else
                    {
                        return -1;
                    }
                }

                return -1;
            }
        }
    }
}
