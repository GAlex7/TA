namespace Animals.Classes
{
    using Intefaces;

    public abstract class Animal : ISound
    {
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name { get; set; }

        public string Sound { get; set; }

        public string Purpose { get; set; }
        
        public int Age { get; set; }

        public Sex Sex { get; set; }

        public string ProduceSound()
        {
            return this.Sound;
        }

        public string Produce()
        {
            return this.Purpose;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
