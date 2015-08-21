// Define abstract class Human with a first name and a last name.
namespace StudentsAndWorkers.Classes
{
    using System.Collections;
    using System.Collections.Generic;

    public abstract class Human 
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
