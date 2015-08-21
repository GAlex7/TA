// Define a new class Student which is derived from Human and has a new field – grade.
namespace StudentsAndWorkers.Classes
{
    public class Student : Human
    {
        public Student(string name, string lastName)
        {
            this.FirstName = name;
            this.LastName = lastName;
        }

        public Student(string name, string lastName, uint grade)
            : this(name, lastName)
        {
            this.Grade = grade;
        }

        public uint Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}, Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
