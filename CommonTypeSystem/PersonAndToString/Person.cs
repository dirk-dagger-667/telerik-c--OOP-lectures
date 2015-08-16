using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndToString
{
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name cannot be a null value!");
                }
                else
                {
                    this.name = value;
                }
                
            }
        }
        public int? Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return this.Name + " Age :  null";
            }
            else
            {
                return this.Name + " " + this.Age;
            }
        }
    }
}
