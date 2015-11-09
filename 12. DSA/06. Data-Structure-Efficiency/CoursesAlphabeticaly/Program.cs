namespace CoursesAlphabeticaly
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main()
        {
            var studentsData = new SortedDictionary<string, Bag<Student>>();

            var fileName = "../../students.txt";

            var lines = File.ReadAllText(fileName).Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var data = line.Split('|');
                var name = data[0].Trim();
                var lname = data[1].Trim();
                var course = data[2].Trim();

                if (!studentsData.ContainsKey(course))
                {
                    studentsData.Add(course, new Bag<Student>());
                }

                studentsData[course].Add(new Student(name, lname, course));
            }

            foreach (var course in studentsData)
            {
                Console.Write(course.Key + ": ");
                var students = course.Value.Select(x => x.FullName).ToArray();
                Array.Sort(students);
                Console.WriteLine(string.Join(", ", students));
            }
        }
    }
}