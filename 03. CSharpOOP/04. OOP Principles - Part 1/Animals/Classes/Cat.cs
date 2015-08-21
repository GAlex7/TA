namespace Animals.Classes
{
    using System;

    using Intefaces;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.Purpose = "I am the terror of mice!";
        }
    }
}
