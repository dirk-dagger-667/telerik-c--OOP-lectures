namespace StudentSelector
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Student
    {
        //public Student(string firstName, string lastName, byte numberOfGroup)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.GroupNumber = numberOfGroup;
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public byte GroupNumber { get; set; }
        public Group Group { get; set; }
    }
}
