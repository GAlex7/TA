namespace Check
{
    using System;
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
    public class AuthorAttribute : System.Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }

    public class VersionAttribute : System.Attribute
    {
        public int major { get; private set; }

        public int minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }
    }
}