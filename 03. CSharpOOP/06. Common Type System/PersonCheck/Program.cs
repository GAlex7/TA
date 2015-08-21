namespace PersonCheck
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var man = new Person("Petar");
            var woman = new Person("Ani", 25);

            Console.WriteLine(man);
            Console.WriteLine(woman);
        }
    }
}
