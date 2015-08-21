namespace Check
{
    using System;

    using Classes;

    public class Program
    {
        public static void Main()
        {
            var student = new Student("Ivan", "Georgiev", "123-01-5678");

            Console.WriteLine(student);
        }
    }
}
