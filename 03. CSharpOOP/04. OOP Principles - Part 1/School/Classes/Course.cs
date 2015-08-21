namespace SchoolCheck.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Course : SchoolObj, ICommentable
    {
        private static List<string> identifiers = new List<string>();

        // field name use as CourseIdentifier
        private List<Teacher> teachers;
        private List<Student> students;

        public Course(string identifier)
        {
            this.CourseIdentifier = identifier;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
            identifiers.Add(identifier);
        }

        public Course(string identifier, ICollection<Student> students)
            : this(identifier)
        {
            this.students.AddRange(students);
        }

        public Course(string identifier, ICollection<Teacher> teachers, ICollection<Student> students)
            : this(identifier, students)
        {
            this.teachers.AddRange(teachers);
        }

        public string CourseIdentifier
        {
            get
            {
                return this.Name;
            }

            private set
            {
                if (identifiers.Contains(value))
                {
                    throw new ArgumentException("Class with this identifier already exist");
                }

                this.Name = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return new List<Teacher>(this.teachers); }
        }

        public List<Student> Students
        {
            get { return new List<Student>(this.students); }
        }

        public void AddTeacher(Teacher teacher)
        {
            if (this.teachers.Contains(teacher))
            {
                throw new ArgumentOutOfRangeException("This teacher already is added");
            }

            this.teachers.Add(teacher);
        }

        public void AddTeacherRange(ICollection<Teacher> teachers)
        {
            foreach (var teacher in teachers)
            {
                this.AddTeacher(teacher);
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Contains(student))
            {
                throw new ArgumentOutOfRangeException("This student already is added");
            }

            this.students.Add(student);
        }

        public void AddStudentRange(ICollection<Student> students)
        {
            foreach (var student in students)
            {
                this.AddStudent(student);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!this.teachers.Contains(teacher))
            {
                throw new ArgumentOutOfRangeException("This teacher does't exist");
            }

            this.teachers.Remove(teacher);
        }

        public void RemoveStudent(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentOutOfRangeException("This student does't exist");
            }

            this.students.Remove(student);
        }
    }
}
