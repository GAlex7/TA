﻿namespace StudentSystem.Data
{
    using Models;
    using Repositories;

    public interface IStudentSystemData
    {
        IGenericRepository<Course> Courses { get; }

        StudentsRepository Students { get; }

        IGenericRepository<Homework> Homeworks { get; }

        IGenericRepository<Test> Tests { get; }

    }
}
