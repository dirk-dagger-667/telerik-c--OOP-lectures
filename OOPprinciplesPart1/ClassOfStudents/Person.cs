using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfStudents
{
    public class Person : INamable, ICommentable
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, string comment)
            : this(name)
        {
            this.Comment = comment;
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value == "" && value == null)
                {
                    this.name = value;
                }
            }
        }
        public string Comment { get; private set; }
    }
}
