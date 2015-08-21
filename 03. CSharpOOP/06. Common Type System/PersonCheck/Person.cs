namespace PersonCheck
{
    using System;

    public class Person
    {
        private string name;
        private uint? age;

        public Person(string name, uint? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public uint? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            string ageAsString = ": " + this.Age.ToString();

            if (this.Age == null)
            {
                ageAsString = " is not specified";
            }

            return string.Format("Name: {0}; Age{1}", this.Name, ageAsString);
        }
    }
}
