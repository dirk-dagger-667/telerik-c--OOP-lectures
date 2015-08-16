using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value <= 0 && value >= 14)
                {
                    throw new ArgumentOutOfRangeException("The grade of the student cannot be less than 1 or more than 13!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public Student(string firstName, string lastName, int grade): base(firstName, lastName)
        {
            if (grade < 1 && grade > 13)
            {
                throw new ArgumentOutOfRangeException("The grade of the student cannot be less than 1 or more than 13!");
            }
            else
            {
                this.grade = grade;
            }
        }
    }
}
