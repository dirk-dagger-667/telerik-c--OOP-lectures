using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class : ICommentable
    {
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        private string uniqueTextIdentifier;
        StringBuilder comment = new StringBuilder();

        public string UniqueTextIdentifier
        {
            get { return this.uniqueTextIdentifier; }
            set 
            {
                if (value.Length == 0)
                {
                    throw new ArgumentNullException("The class' UTI cannot be a null value!");
                }
                this.uniqueTextIdentifier = value; 
            }
        }
        public List<Student> Students
        {
            get { return this.students; }
            protected set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("The number of students cannot be 0!");
                }
                this.students = value;
            }
        }
        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            protected set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("The number of students cannot be 0!");
                }
                this.teachers = value;
            }
        }

        public Class(List<Student> students, List<Teacher> teachers, string uniqueTextIdentifier)
        {
            if (students.Count == 0)
            {
                throw new ArgumentOutOfRangeException("The number of students cannot be 0!");
            }
            else if(teachers.Count == 0)
            {
                throw new ArgumentOutOfRangeException("The number of teachers cannot be 0!");
            }
            else if(uniqueTextIdentifier.Length == 0)
            {
                throw new ArgumentNullException("The UTI cannot be null!");
            }
            else
            {
                this.students = students;
                this.teachers = teachers;
                this.uniqueTextIdentifier = uniqueTextIdentifier;
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
