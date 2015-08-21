namespace SchoolCheck
{
    using System;
    using System.Collections.Generic;

    using Classes;
    using Interfaces;

    public class Check
    {
        public static void Main()
        {
            var disciplines = GetDisciplines();
            var teacher = new Teacher("Ivaylo Kenov", disciplines);
            teacher.AddComment("The best one!");

            var student = new Student("Ivancho");
            Console.WriteLine(student.ID);

            var course = new Course("a");
            course.AddTeacher(teacher);
            course.AddStudent(student);
        }

        private static List<Discipline> GetDisciplines()
        {
            var newDisciplines = new List<Discipline>()
            {
                new Discipline("Mathematics", 50, 20),
                new Discipline("Informatics", 100, 50),
            };
            return newDisciplines;
        }
    }
}
