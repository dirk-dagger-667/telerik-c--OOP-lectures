using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfStudents
{
    public class Class : ICommentable
    {
        public Class(List<Teacher> teachers, string UTI)
        {
            this.Teacher = teachers;
            this.UniqueTextIdentifier = UTI;
        }
        public Class(List<Teacher> teachers, string UTI, string comment)
            : this(teachers, UTI)
        {
            this.Comment = comment;
        }
        public List<Teacher> Teacher{ get; private set;}
        public string UniqueTextIdentifier { get; private set; }
        public string Comment { get; private set; }
    }
}
