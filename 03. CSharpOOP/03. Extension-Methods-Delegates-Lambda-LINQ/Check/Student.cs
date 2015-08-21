namespace Check
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    //FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.

    public class Student
    {
        private int age;
        private string email;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!IsEmail(value))
                {
                    throw new ArgumentException("This e-mail is not valid");
                }
                this.email = value;
            }
        }
        
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException();
                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        private bool IsEmail(string value)
        {
            return Regex.IsMatch(value.ToLower(), @"^[a-z|0-9]*([_][a-z|0-9]+)*([.][a-z|0-9]+)*([.][a-z|0-9]+)*(([_][a-z|0-9]+)*)?@[a-z][a-z|0-9]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$");
        }
    }
}
