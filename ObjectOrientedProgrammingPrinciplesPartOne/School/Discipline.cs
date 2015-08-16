using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : ICommentable
    {
        private string name;
        private long number;
        private int numberOfExercises;
        StringBuilder comment = new StringBuilder();

        public string Name
        {
            get { return this.name; }
            set 
            {   
                if (value == null)
                {
                    throw new ArgumentNullException("The name of the discipline cannot be null!");
                }
                this.name = value;
            }
        }
        public long Number
        {
            get { return this.number; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of a discipline cannot be negative or equal to 0!");
                }
                this.number = value;
            }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of excercises in a discipline cannot be negative or equal 0!");
                }
                this.numberOfExercises = value;
            }
        }

        public Discipline(string name, long number, int numberOfExercises)
        {
            this.name = name;
            this.number = number;
            this.numberOfExercises = numberOfExercises;
        }

        public void AddComment(string comment)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(comment);
            this.comment = sb;
        }
        public void DeleteComments()
        {
            this.comment = null;
        }
        public void PrintComments()
        {
            Console.WriteLine(this.comment.ToString());
        }
    }
}
