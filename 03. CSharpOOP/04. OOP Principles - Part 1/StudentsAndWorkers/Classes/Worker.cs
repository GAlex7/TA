// Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() 
// that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.

namespace StudentsAndWorkers.Classes
{
    using System;

    public class Worker : Human
    {
        private const int WorkHourPerWeek = 40;

        public Worker(string name, string lastName, decimal weekSalary)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
        }

        public decimal WeekSalary { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / WorkHourPerWeek;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, money per hour: {2:f2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
