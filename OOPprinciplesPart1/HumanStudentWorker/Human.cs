using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value != "" && value != null)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (value != "" && value != null)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
    }
}
