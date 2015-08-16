using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            :base(firstName, lastName)
        {
            this.Grade = grade;
        }
        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.grade = value;
                }
            }
        }
    }
}
