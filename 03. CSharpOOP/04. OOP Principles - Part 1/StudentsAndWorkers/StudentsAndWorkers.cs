namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Classes;

    public class StudentsAndWorkers
    {
        private static Random rnd = new Random();

        public static void Main()
        {
            int count = 10;

            int minGrade = 2;
            int maxGrade = 6;

            decimal minSalary = 0;
            decimal maxSalary = 5000;

            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                var grade = rnd.Next(minGrade, maxGrade + 1);

                students.Add(new Student(GenerateName(), GenerateName(), (uint)grade));
            }

            var sortedStudents = students
                .OrderBy(x => x.Grade)
                .ToList();

            Print(sortedStudents);

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            var workers = new List<Worker>();
            for (int i = 0; i < count; i++)
            {
                var salary = (decimal)rnd.Next((int)minSalary, (int)maxSalary + 1);

                workers.Add(new Worker(GenerateName(), GenerateName(), salary));
            }

            var sortedWorkers = workers
                .OrderByDescending(w => w.MoneyPerHour())
                .ToList();

            Print(sortedWorkers);

            // Merge the lists and sort them by first name and last name.
            var people = new List<Human>(students);
            people.AddRange(workers);

            var sortedPeople = people
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToArray();

            Print(sortedPeople);
        }

        private static string GenerateName()
        {
            var maxLength = 15;
            var name = new StringBuilder();
            name.Append((char)rnd.Next('A', 'Z'));

            for (int i = 0; i < rnd.Next(3, maxLength); i++)
            {
                name.Append((char)rnd.Next('a', 'z'));
            }

            return name.ToString();
        }

        private static void Print(IEnumerable<Human> collection)
        {
            foreach (var person in collection)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}
