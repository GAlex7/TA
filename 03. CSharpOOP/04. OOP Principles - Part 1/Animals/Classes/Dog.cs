namespace Animals.Classes
{
    using System;

    using Intefaces;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.Sound = "Uaw";
            this.Purpose = "I guard here!";
        }
    }
}
