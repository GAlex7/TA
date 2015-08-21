// Problem 14. Integer calculations

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.


namespace P14_IntegerCalculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class IntegerCalculations
    {
        static decimal Minimum(decimal[] arr)
        {
            decimal result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < result)
                {
                    result = arr[i];
                }
            }
            return result;
        }

        static decimal Maximum(decimal[] arr)
        {
            decimal result = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > result)
                {
                    result = arr[i];
                }
            return result;
        }

        static decimal Average(decimal[] arr)
        {
            decimal result = Sum(arr) / arr.Length;
            return result;
        }

        static decimal Sum(decimal[] arr)
        {
            decimal result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }

        static decimal Product(decimal[] arr)
        {
            decimal result = arr[1];
            for (int i = 1; i < arr.Length; i++)
            {
                result *= arr[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter a sequence of numbers: ");
            string input = Console.ReadLine();
            string[] arrAsStr = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal[] arr = new decimal[arrAsStr.Length];
            for (int i = 0; i < arrAsStr.Length; i++)
            {
                arr[i] = decimal.Parse(arrAsStr[i]);
            }
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("What do you want to know about it?");
            Console.WriteLine("1. minimum");
            Console.WriteLine("2. maximum");
            Console.WriteLine("3. average");
            Console.WriteLine("4. sum");
            Console.WriteLine("5. product");
            Console.WriteLine("or everything...");
            Console.SetCursorPosition(35, 0);
            int choise = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 8);
            Console.WriteLine(string.Join(", ",arr));
            Console.WriteLine();
            switch (choise)
            {
                case 1: Console.WriteLine("Min -> {0}", Minimum(arr)); break;
                case 2: Console.WriteLine("Max -> {0}", Maximum(arr)); break;
                case 3: Console.WriteLine("Avg -> {0}", Average(arr)); break;
                case 4: Console.WriteLine("Sum -> {0}", Sum(arr)); break;
                case 5: Console.WriteLine("Prd -> {0}", Product(arr)); break;
                default:
                    {
                        Console.WriteLine("Min -> {0}", Minimum(arr));
                        Console.WriteLine("Max -> {0}", Maximum(arr));
                        Console.WriteLine("Avg -> {0}", Average(arr));
                        Console.WriteLine("Sum -> {0}", Sum(arr));
                        Console.WriteLine("Prd -> {0}", Product(arr));
                        break;
                    }
            }
        }
    }
}
