using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfStudents
{
    public class Student : Person, INamable, ICommentable
    {
        public Student(string name, string UCI)
            : base(name)
        {
            this.UniqueClassIdentifier = UCI;
        }
        public Student(string name, string UCI, string comment)
            : base(name, comment)
        {
            this.UniqueClassIdentifier = UCI;
        }
        public Student(string name, string UCI)
            : base(name)
        {
            this.UniqueClassIdentifier = UCI;
        }

        public string UniqueClassIdentifier { get; private set; }
    }
}
