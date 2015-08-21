// Problem 12.* Zero Subset

// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.

using System;
using System.Globalization;
using System.Threading;
class ZeroSubset
{
    static void Main()
    {
        byte numCounts = 5;
        bool isZeroSubset = false;
        string input = Console.ReadLine();
        string[] numStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] num = new int[numCounts];
        // Convert string to numbers
        for (int i = 0; i < numCounts; i++)       
        {
            num[i] = int.Parse(numStr[i]);
        }
        //-----------------------------------
        for (int i = 1; i < Math.Pow(2, numCounts); i++)
        {
            int sum = 0;
            string result = "";
            bool checkPlus = false;                         // when to store "+" in result
            for (int j = 0; j < numCounts; j++)
            {
                byte mask = (byte)Math.Pow(2, j);           // BitWise
                if ((mask & i) > 0)
                {
                    if (checkPlus)
                    {
                        result += " + ";
                    }
                    sum += num[j];
                    result += Convert.ToString(num[j]);
                    checkPlus = true;
                }
            }
            result += " = 0";
            if (sum == 0)
            {
                Console.WriteLine(result);
                isZeroSubset = true;
            }
        }
        if (!isZeroSubset)
        {
            Console.WriteLine("no zero subset");
        }
    }
}