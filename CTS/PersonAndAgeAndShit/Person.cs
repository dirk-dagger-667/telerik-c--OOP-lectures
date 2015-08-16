namespace PersonAndAgeAndShit
{
    using System;
    using System.Text;
    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == "" && value == String.Empty)
                {
                    throw new ArgumentNullException("the name cannot be null or empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int? Age { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Name : " + this.Name);

            if (this.Age != null)
            {
                result.Append("Age : " + this.Age);
            }
            else
            {
                result.Append("Age is null");
            }

            return result.ToString();
        }
    }
}
