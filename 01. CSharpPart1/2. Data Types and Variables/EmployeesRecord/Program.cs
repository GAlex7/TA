//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics: 
//First name; Last name; Age (0..100); Gender (m/f); Personal ID number (e.g.8306112507) and Unique employee number (27560000..27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names. Print the data at the console.

using System;

class EmployeesRecord
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 31;
        char gender = 'm';
        int idNumber = 27560013;
        Console.WriteLine("Name: " + firstName + " " + lastName + "\n Age: " + age + "\n Gender: " + gender + "\n  ID Number: " + idNumber);
    }
}