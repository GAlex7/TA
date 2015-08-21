namespace Check
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            var myStr = new StringBuilder("Proba");
            Console.WriteLine(myStr.Substring(0, 3));

            var myCollection = new[] { 1, 2, 3, 4, 5, 13 };
            Console.WriteLine("Average -> {0}", myCollection.Average());
            Console.WriteLine("Product -> {0}", myCollection.Product());
            Console.WriteLine();

            var students = new Student[4];
            students[0] = new Student
            {
                FirstName = "Ivan",
                LastName = "Georgiev",
                Age = 19,
                GroupNumber = 1,
                Email = "mynewmail@abv.bg",
                Tel = "0888123456",
                Marks = new List<int> { 6, 6 },
                FN = 123406789,
            };

            students[1] = new Student
            {
                FirstName = "Ana",
                LastName = "Georgieva",
                Age = 17,
                GroupNumber = 1,
                Email = "a@fd.b",
                Tel = "02/8123456",
                Marks = new List<int> { 2, 2, 4 },
                FN = 123406789,
            };

            students[2] = new Student
            {
                FirstName = "Gergana",
                LastName = "Hristova",
                Age = 21,
                GroupNumber = 2,
                Email = "mail@gmail.com",
                Tel = "0888123456",
                Marks = new List<int> { 6, 3, 6, 4 },
                FN = 123405789,
            };

            students[3] = new Student
            {
                FirstName = "Ivan",
                LastName = "Antonov",
                Age = 25,
                GroupNumber = 2,
                Email = "hello@abv.bg",
                Tel = "028123458",
                Marks = new List<int> { 4, 3 },
                FN = 123404789,
            };

            var result = Check.ExtMethods.FirstBeforeLast(students);
            Print(result);

            result = Check.ExtMethods.AgeRange(students, 18, 24);
            Print(result);

            result = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToArray();
            Print(result);

            var linkResult =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            Print(linkResult);

            result = students
                .Where(x => x.GroupNumber == 2)
                .OrderBy(x => x.FirstName)
                .ToArray();
            Console.WriteLine("Students in group 2 are (selected by Lambda):");
            Print(result);

            result = students
                .Where(x => x.Email.Substring(x.Email.IndexOf('@') + 1).Equals("abv.bg"))
                .ToArray();
            Console.WriteLine("Student(s) with email in abv.bg is/are:");
            Print(result);

            var resultSofiaPhone =
                from student in students
                where student.Tel.StartsWith("02")
                select student;
            Console.WriteLine("Student(s) with phone in Sofia is/are:");
            Print(resultSofiaPhone);

            var excellentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };
            Console.WriteLine(string.Join(", ", excellentStudents));
            Console.WriteLine();

            result = students
                .Where(x => x.Marks.Count == 2)
                .ToArray();
            Console.WriteLine("Students with exactly two marks:");
            Print(result);

            var marks = students
                .Where(x => x.FN.ToString().Substring(4, 2) == "06")
                .Select(x => x.Marks);
            Console.WriteLine("All marks in 2006");
            foreach (var mark in marks)
            {
                Console.WriteLine(string.Join(", ", mark));
            }

            var res = 
                from x in students
                group x by x.GroupNumber;
            Console.WriteLine("Students in groups:");
            foreach (var group in res)
            {
                Console.Write("Group ");
                Console.WriteLine(group.Key);
                foreach (var st in group)
                {
                    Console.WriteLine(st);
                }
            }
            Console.WriteLine();

            var resLambda = students
                .GroupBy(x => x.GroupNumber);
            Console.WriteLine("Students in groups (Lambda):");
            foreach (var group in resLambda)
            {
                Console.Write("Group ");
                Console.WriteLine(group.Key);
                foreach (var st in group)
                {
                    Console.WriteLine(st);
                }
            }

        }

        private static void Print(IEnumerable<Student> collection)
        {
            Console.WriteLine("-----------BEGIN--------------------");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------END---------------------");
            Console.WriteLine();
        }

    }
}
