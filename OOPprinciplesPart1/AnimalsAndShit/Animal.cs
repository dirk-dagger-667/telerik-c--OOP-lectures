using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsAndShit
{
    public class Animal : ISound
    {
        private const bool initailGenderIfMale = true;
        private int age;
        private string name;
        private bool gender;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = initailGenderIfMale;
        }

        public Animal(string name, int age, bool gender)
            :this(name, age)
        {
            this.Gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.age = value;
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
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public bool Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public virtual void MakeSound()
        {
            
        }
    }
}
