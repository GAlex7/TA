namespace SchoolCheck.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class School : SchoolObj, ICommentable
    {
        private List<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        public School(string name, List<Course> courses)
            : this(name)
        {
            this.courses = courses;
        }

        public List<Course> Courses
        {
            get { return new List<Course>(this.courses); }
        }
    }
}
