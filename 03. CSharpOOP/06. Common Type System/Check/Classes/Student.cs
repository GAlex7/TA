namespace Check.Classes
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    using Enums;

    public class Student : ICloneable, IComparable<Student>
    {
        private string ssn;
        private string firstName;
        private string middleName;
        private string lastName;
        private string email;

        public Student(string name, string lastName, string ssn)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (!this.IsCorrectName(value))
                {
                    throw new ArgumentException();
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (!this.IsCorrectName(value))
                {
                    throw new ArgumentException();
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (!this.IsCorrectName(value))
                {
                    throw new ArgumentException();
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }

            set
            {
                if (!this.IsCorrectSSN(value))
                {
                    throw new ArgumentException("This SSN is not valid");
                }

                this.ssn = value;
            }
        }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (!this.IsEmail(value))
                {
                    throw new ArgumentException("This e-mail is not valid");
                }

                this.email = value;
            }
        }

        public int Course { get; set; }

        public Specialties Specialty { get; set; }

        public Universities University { get; set; }

        public Faculties Faculty { get; set; }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.Equals(s2);
        }

        public static bool operator !=(Student s1, Student s2)
        {
            return !s1.Equals(s2);
        }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName) ||
                !this.MiddleName.Equals((obj as Student).MiddleName) ||
                !this.LastName.Equals((obj as Student).LastName) ||
                !this.SSN.Equals((obj as Student).SSN) ||
                !this.MobilePhone.Equals((obj as Student).MobilePhone) ||
                !this.PermanentAddress.Equals((obj as Student).PermanentAddress) ||
                !this.Email.Equals((obj as Student).Email) ||
                !this.Faculty.Equals((obj as Student).Faculty) ||
                !this.Course.Equals((obj as Student).Course) ||
                !this.University.Equals((obj as Student).University) ||
                !this.Specialty.Equals((obj as Student).Specialty))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() *
                this.FirstName.GetHashCode() *
                this.MiddleName.GetHashCode() *
                this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(string.Format("SSN: {0}", this.SSN));
            result.AppendLine(string.Format("Address: {0}", this.PermanentAddress));
            result.AppendLine(string.Format("Phone: {0}", this.MobilePhone));
            result.AppendLine(string.Format("Email: {0}", this.Email));
            result.AppendLine(string.Format("{0}, faculty: {1}, specialty: {2}, course {3}", this.University, this.Faculty, this.Specialty, this.Course));

            return result.ToString();
        }

        public object Clone()
        {
            var obj = new Student(this.FirstName, this.LastName, this.SSN);
            obj.Course = this.Course;
            obj.Email = this.Email;
            obj.Faculty = this.Faculty;
            obj.MiddleName = this.MiddleName;
            obj.MobilePhone = this.MobilePhone;
            obj.PermanentAddress = this.PermanentAddress;
            obj.Specialty = this.Specialty;
            obj.University = this.University;

            return obj;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) != 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName.CompareTo(other.MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName.CompareTo(other.LastName) != 0)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            return this.SSN.CompareTo((other as Student).SSN);
        }

        private bool IsCorrectName(string text)
        {
            foreach (char ch in text.ToLower())
            {
                if (!char.IsLetter(ch) && ch != '-')
                {
                    return false;
                }
            }

            if (text[0].ToString() != text[0].ToString().ToUpper())
            {
                return false;
            }

            return true;
        }

        private bool IsEmail(string value)
        {
            return Regex.IsMatch(value.ToLower(), @"^[a-z|0-9]*([_][a-z|0-9]+)*([.][a-z|0-9]+)*([.][a-z|0-9]+)*(([_][a-z|0-9]+)*)?@[a-z][a-z|0-9]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$");
        }

        private bool IsCorrectSSN(string text)
        {
            if (text.Length != 11 ||
                text[3] != '-' ||
                text[6] != '-')
            {
                return false;
            }

            var areaNumber = int.Parse(text.Substring(0, 3));
            var groupNumber = int.Parse(text.Substring(4, 2));
            var serialNumber = int.Parse(text.Substring(7));

            if (areaNumber * groupNumber * serialNumber == 0)
            {
                return false;
            }

            if (areaNumber == 666 || areaNumber >= 900)
            {
                return false;
            }

            return true;
        }
    }
}