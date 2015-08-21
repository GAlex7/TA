using System;

namespace Methods
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.DateOfBirth > other.DateOfBirth;
        }
    }
}
