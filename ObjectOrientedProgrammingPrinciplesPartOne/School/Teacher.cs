using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines = new List<Discipline>();
        private StringBuilder comment = new StringBuilder();

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException("The number of disciplines that a teacher teaches cannot be 0!");
                }
            }
        }

        public Teacher()
        {

        }
        public Teacher(string name)
        {
            if (name != null)
            {
                this.Name = name;
            }
            else
            {
                throw new ArgumentNullException("The name of the teacher cannot be a null value!");
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
