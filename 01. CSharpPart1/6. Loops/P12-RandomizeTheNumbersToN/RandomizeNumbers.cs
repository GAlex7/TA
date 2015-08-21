// Problem 12.* Randomize the Numbers 1…N
// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
class RandomizeNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int rndNum, count = 0;
        int[] nums = new int[num];
        bool[] check = new bool[num];
        bool isFull = false;
        for (int i = 0; i < num; i++)
        {
            nums[i] = i + 1;
            check[i] = false;
        }
        Random rnd = new Random();
        while (count < num-1)
        {
            rndNum = rnd.Next(0, num - 1);
            if (!check[rndNum])
            {
                Console.Write("{0} ", nums[rndNum]);
                check[rndNum] = true;
                count++;
            }
        }
        for (int i = 0; i < num; i++)
        {
            if (!check[i])
            {
                Console.WriteLine(nums[i]);
                break;
            }
        }
    }
}