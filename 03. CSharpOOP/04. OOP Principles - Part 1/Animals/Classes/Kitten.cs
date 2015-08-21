namespace Animals.Classes
{
    using System;

    using Intefaces;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {
            this.Sound = "Miau";
        }
    }
}
