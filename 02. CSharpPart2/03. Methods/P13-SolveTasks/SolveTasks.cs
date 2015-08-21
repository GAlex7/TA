// Problem 13. Solve tasks

// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0
// Create appropriate methods.
// Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
// The decimal number should be non-negative
// The sequence should not be empty
// a should not be equal to 0


namespace P13_SolveTasks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using P07_ReverseNumber;

    class SolveTasks
    {
        static void Main(string[] args)
        {
            decimal numb = 0;
            decimal numbB = 0;
            string input = "123";
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculate the average of a sequence of integers");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0");
            Console.Write("Please enter your choise: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    {
                        do
                        {
                            if (numb < 0)
                                Console.WriteLine("Non-negative!!!");
                            Console.Write("Please enter a non-negative number: ");
                            numb = decimal.Parse(Console.ReadLine());
                        } while (numb < 0);
                        Console.WriteLine(ReverseNumber.ReverseNumb(numb));
                        break;
                    }
                case 2:
                    {
                        do
                        {
                            if (input.Length < 1)
                            {
                                Console.WriteLine("The sequence should not be empty!");
                            }
                            Console.Write("Please enter a sequence of numbers: ");
                            input = Console.ReadLine();
                        } while (input.Length < 1);
                        string[] arrAsStr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                        int[] arr = new int[arrAsStr.Length];
                        decimal sum = 0;
                        for (int i = 0; i < arrAsStr.Length; i++)
                        {
                            arr[i] = int.Parse(arrAsStr[i]);
                            sum += arr[i];
                        }
                        Console.WriteLine("\nAverage is: {0}", sum/arr.Length);
                        break;
                    }
                case 3:
                    {
                        do
                        {
                            if (numb == 0)

                                Console.WriteLine("A should not be equal to 0!");
                            Console.Write("A= ");
                            numb = decimal.Parse(Console.ReadLine());
                        } while (numb == 0);
                        Console.Write("B= ");
                        numbB = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("X= {0}", -numbB / numb);
                        break;
                    }
                default: Console.WriteLine("Incorect choise!");
                    break;
            }
            //  );
        }
    }
}
