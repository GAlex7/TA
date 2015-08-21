namespace Animals.Classes
{
    using System;

    using Intefaces;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, Sex.Female)
        {
            this.Sound = "Kwak";
            this.Purpose = "I am horror to flies!";
        }
    }
}
