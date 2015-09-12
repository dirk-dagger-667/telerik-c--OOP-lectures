using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).


namespace Animals
{
    public class Animal
    {
        protected int age;
        protected string name;
        protected string sex;

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0 && value > 50)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be a negative value or more than 50!");
                }
                this.age = value; 
            }
        }
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name cannot be a null value!");
                }
            }
        }
        public string Sex
        {
            get { return this.sex; }
            set 
            {
                if (value != "male" && value != "female" && value != null)
                {
                    throw new ArgumentException("The sex can be only male or female( can't be a shemale)!");
                }
                else
                {
                    this.sex = value;
                }
            }
        }

        public Animal(int age, string name, string sex)
        {
            if (age < 0 && age > 50)
            {
                throw new ArgumentOutOfRangeException("Age cannot be a negative value or more than 50!");
            }
            else if (name == null)
            {
                throw new ArgumentNullException("The name cannot be a null value!");
            }
            else if (sex != "male" && sex != "female" && sex != null)
            {
                throw new ArgumentException("The sex can be only male or female( can't be a shemale), or null value!");
            }
            else
            {
                this.age = age;
                this.name = name;
                this.sex = sex;
            }
        }
            
    }
}
