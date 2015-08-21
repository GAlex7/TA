// Problem 9. Sum of n Numbers
// Write a program that enters a number n and after that enters more n numbers and 
// calculates and prints their sum.
// Note: You may need to use a for-loop.

using System;
using System.Globalization;
using System.Threading;
class SumOfNNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        int count = int.Parse(Console.ReadLine());
        float[] nums = new float[count];
        float sum = 0;
        for (int i = 0; i < count; i++)
        {
            nums[i] = float.Parse(Console.ReadLine().Replace('.', ','));
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }
}