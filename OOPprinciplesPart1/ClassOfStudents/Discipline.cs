using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOfStudents
{
    public class Discipline : INamable, ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comment = comment;
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.numberOfExercises = value;
                }
            }
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
