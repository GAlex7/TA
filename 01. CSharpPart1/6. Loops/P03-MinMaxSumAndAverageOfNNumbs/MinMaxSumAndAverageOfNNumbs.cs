// Problem 3. Min, Max, Sum and Average of N Numbers
// Write a program that reads from the console a sequence of n integer numbers and 
// returns the minimal, the maximal number, the sum and the average of all numbers 
// (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, 
// each holding an integer number.
// The output is like in the examples below.

using System;
class MinMaxSumAndAverageOfNNumbs
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[] nums = new int[count];
        for (int i = 0; i < count; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        int min = nums[0], max = nums[0], sum = 0;
        for (int i = 0; i < count; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
            if (nums[i] < min)
            {
                min = nums[i];
            }
            sum += nums[i];
        }
        float avg = sum / (float)count;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:f2}", min, max, sum, avg);
    }
}