namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Classes;
    using Intefaces;

    public class AnimalCheck
    {
        public static void Main()
        {
            var animals = new List<Animal>();

            var kitten = new Kitten("Kitty", 2);

            SayAngAddToList(kitten, animals);

            var tomcat = new Tomcat("Tom", 1);

            SayAngAddToList(tomcat, animals);

            var frog = new Frog("Froggy", 5, Sex.Male);

            SayAngAddToList(frog, animals);

            var dog = new Dog("Sharo", 4, Sex.Male);

            SayAngAddToList(dog, animals);

            var anotherDog = new Dog("Lassy", 7, Sex.Female);

            SayAngAddToList(anotherDog, animals);

            Console.WriteLine("The average age of all animal is {0}", animals.Average(x => x.Age));
        }

        private static void SayAngAddToList(Animal animal, ICollection<Animal> collection)
        {
            AnimalSaid(animal);

            collection.Add(animal);
        }

        private static void AnimalSaid(Animal animal)
        {
            Console.WriteLine("{0} say {1}.", animal, animal.ProduceSound());
        }
    }
}
