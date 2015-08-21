namespace SchoolCheck.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Teacher : People, ICommentable
    {
        public Teacher(string name, IEnumerable<Discipline> discipl)
        {
            this.Name = name;
            this.Disciplines = new List<Discipline>(discipl);
        }

        public List<Discipline> Disciplines { get; set; }
    }
}
