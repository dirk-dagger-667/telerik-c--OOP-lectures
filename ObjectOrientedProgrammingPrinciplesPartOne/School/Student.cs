using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Student : Person, ICommentable
    {
        private long number;
        StringBuilder comment = new StringBuilder();

        public long Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of the student cannot be less or equal to 0!");
                }
                this.number = value;
            }
        }

        public Student(string name, long number)
        {
            if (name == null)
            {
                throw new ArgumentNullException("The name of the student cannot be null!");
            }
            else if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("The number of the student cannot be less or equal to 0!");
            }
            else
            {
                this.Name = name;
                this.number = number;
            }
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
