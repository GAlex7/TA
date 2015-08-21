namespace SchoolCheck.Classes
{
    using System;
    using System.Text;

    using Interfaces;

    public class People : ICommentable
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.IsCorrectName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("The name isn't corect");
                }
            }
        }

        public string Comment { get; set; }

        public virtual void AddComment(string text = "There's no comment yet")
        {
            this.Comment = text;
        }

        private bool IsCorrectName(string text)
        {
            foreach (char ch in text)
            {
                if (!char.IsLetter(ch) && ch != ' ' && ch != '-')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
