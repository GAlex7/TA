namespace CoursesAlphabeticaly
{
    public class Student
    {
        public Student(string fname, string lname, string course)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.FullName = fname + ' ' + lname;
            this.Course = course;
        }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Course { get; set; }
    }
}
