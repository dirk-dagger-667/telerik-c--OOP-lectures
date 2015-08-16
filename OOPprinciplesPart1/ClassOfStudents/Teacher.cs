using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfStudents
{
    public class Teacher : Person, INamable, ICommentable
    {
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }
        public Teacher(string name, List<Discipline> disciplines, string comment)
            : base(name, comment)
        {
            this.Disciplines = disciplines;
        }
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }
        public List<Discipline> Disciplines { get; private set; }
    }
}
