namespace SchoolCheck.Classes
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Discipline : SchoolObj, ICommentable
    {
        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, uint lectures, uint exercises)
            : this(name)
        {
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }

        public uint NumberOfLectures { get; set; }

        public uint NumberOfExercises { get; set; }
    }
}
