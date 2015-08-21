namespace Animals.Classes
{
    using System;

    using Intefaces;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.Female)
        {
            this.Sound = "MiaaaauU";
        }
    }
}
