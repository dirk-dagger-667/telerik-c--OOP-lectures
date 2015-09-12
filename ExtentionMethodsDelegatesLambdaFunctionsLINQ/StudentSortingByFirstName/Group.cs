using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
//Implement the previous using the same query expressed with lambda functions.
//Extract all students that have email in abv.bg. Use string methods and LINQ.
//Extract all students with phones in Sofia. Use LINQ.
//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
//Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
//Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
//Rewrite the previous using extension methods.


namespace StudentSortingByFirstName
{
    public class Group
    {
        private int groupNumber;
        private string departamentName;
        private string groupName;

        public Group(string groupName, int groupNumber)
        {
            this.groupName = groupName;
            this.groupNumber = groupNumber;
        }
        public Group(int groupNumber, string departamentName)
        {
            this.groupNumber = groupNumber;
            this.departamentName = departamentName;
        }

        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set {this.groupNumber = value; }
        }
        public string DepartamentName
        {
            get { return this.departamentName; }
            set { this.departamentName = value; }
        }
    }
}
