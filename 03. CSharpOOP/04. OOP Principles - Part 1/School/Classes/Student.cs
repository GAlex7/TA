namespace SchoolCheck.Classes
{
    using System;

    using Interfaces;

    public class Student : People, ICommentable
    {
        private static int uniqueID;
        private int iD;

        public Student(string name)
        {
            this.Name = name;
            this.iD = uniqueID;
            uniqueID++;
        }

        public int ID
        {
            get
            {
                return this.iD;
            }
        }
    }
}
