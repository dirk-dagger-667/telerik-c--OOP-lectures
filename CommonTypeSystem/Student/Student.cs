using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
//Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace StudentCoursesAndSoOn
{
    public enum Faculties
    {
        SocialStudies, Electrical, Electronics, Telecommunications, Nuclear, BankingAndFinancial, Accounting, NaturalSciences
    }
    public enum Universities
    {
        TechincalUnerversity, NewBulgarianUniversity, UniversityOfNationalAndWorldManagement
    }
    public enum Specialities
    {
        History, English, German, ElectronicsEngineering, ElectricalEngineering, Telecommunications, NuclearTechnologies, Banking, Financing, Management, Mathematics
    }

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long sSN;
        private string permanentAddress;
        private string mobilePhoneEmail;
        private long course;
        public Faculties Faculty { get; set; }
        public Universities University { get; set; }
        public Specialities Specialty { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The first name cannot be a null value!");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The middle name cannot be a null value!");
                }
                else
                {
                    this.middleName = value;
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The last name cannot be a null value!");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public long SSN
        {
            get { return this.sSN; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The SSN cannot be less or equal than 0!");
                }
                else
                {
                    this.sSN = value;
                }
            }
        }
        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The address cannot be a null value!");
                }
                else
                {
                    this.permanentAddress = value;
                }
            }
        }
        public string MobilePhoneEmail
        {
            get { return this.mobilePhoneEmail; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The mobile phone e-mial cannot be a null value!");
                }
                else
                {
                    this.mobilePhoneEmail = value;
                }
            }
        }
        public long Course
        {
            get { return this.course; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("The course cannot be a null value!");
                }
                else
                {
                    this.course = value;
                }
            }
        }

        public Student(string firstName, string middleName, string lastName, long ssn, string permanentAddress, string mobilePhoneEmail, long course, Universities university, Faculties faculty, Specialities specialty)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.sSN = ssn;
            this.permanentAddress = permanentAddress;
            this.mobilePhoneEmail = mobilePhoneEmail;
            this.course = course;
            this.University = university;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (this.FirstName != student.FirstName)
            {
                return false;
            }
            if (this.MiddleName != student.MiddleName)
            {
                return false;
            }
            if (this.LastName != student.LastName)
            {
                return false;
            }
            if (this.SSN != student.SSN)
            {
                return false;
            }
            if (this.PermanentAddress != student.PermanentAddress)
            {
                return false;
            }
            if (this.Course != student.Course)
            {
                return false;
            }
            if (this.University != student.University)
            {
                return false;
            }
            if (this.Faculty != student.Faculty)
            {
                return false;
            }
            if (this.Specialty != student.Specialty)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.Course.GetHashCode();
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}\nSSN: {3}\nAddress: {4}\nMobile e-mail: {5}\nCourse: {6}\nUniversity: {7} Faculty: {8} Specialty: {9}", this.FirstName, this.MiddleName, this.LastName, this.PermanentAddress, this.MobilePhoneEmail, this.Course, this.University.ToString(), this.Faculty.ToString(), this.Specialty.ToString());
        }
        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            return Student.Equals(studentOne, studentTwo);
        }
        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return (!(Student.Equals(studentOne, studentTwo)));
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhoneEmail, this.Course, this.University, this.Faculty, this.Specialty);
        }

        public int CompareTo(Student other)
        {
            if (String.CompareOrdinal(this.FirstName, other.FirstName) != 0)
            {
                return String.CompareOrdinal(this.FirstName, other.FirstName);
            }
            else
            {
                if (String.CompareOrdinal(this.MiddleName, other.MiddleName) != 0)
                {
                    return String.CompareOrdinal(this.MiddleName, other.MiddleName);
                }
                else
                {
                    if (String.CompareOrdinal(this.LastName, other.LastName) != 0)
                    {
                        return String.CompareOrdinal(this.LastName, other.LastName);
                    }
                    else
                    {
                        if (this.SSN != other.SSN)
                        {
                            return (int)(this.SSN - other.SSN);
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
