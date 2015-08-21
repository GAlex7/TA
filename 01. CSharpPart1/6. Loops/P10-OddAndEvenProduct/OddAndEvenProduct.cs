// Problem 10. Odd and Even Product
// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to 
// the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;
using System.Globalization;
using System.Threading;
class OddAndEvenProduct
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        string input = Console.ReadLine();
        string[] numStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[numStr.Length];
        int productOdd = 1, productEven = 1;
        for (int i = 0; i < numStr.Length; i++)
        {
            nums[i] = int.Parse(numStr[i]);
            if (i % 2 == 0)
            {
                productOdd *= nums[i];
            }
            else
            {
                productEven *= nums[i];
            }
        }
        if (productEven == productOdd)
        {
            Console.WriteLine("Yes, Product = {0}", productEven);
        }
        else
        {
            Console.WriteLine("No, odd_product  = {0}\nand even_product = {1}", productOdd, productEven);
        }
    }
}