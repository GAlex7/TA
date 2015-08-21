namespace SchoolCheck.Classes
{
    using System;

    using Interfaces;

    public class SchoolObj : ICommentable
    {
        public string Name { get; set; }

        public string Comment { get; set; }

        public virtual void AddComment(string text = "There's no comment yet")
        {
            this.Comment = text;
        }
    }
}
