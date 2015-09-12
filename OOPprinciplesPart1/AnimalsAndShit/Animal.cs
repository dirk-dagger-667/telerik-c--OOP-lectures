using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


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
