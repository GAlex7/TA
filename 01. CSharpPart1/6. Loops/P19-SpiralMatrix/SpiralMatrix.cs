// Problem 19.** Spiral Matrix
// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
// prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
// Examples:

//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7

using System;
class SpiralMatrix
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int x = 0, y = 0, nextNum = 1;
        int n = 0; // start position
        int m = num - 1; // end position 
        int[,] matrix = new int[num, num];
        while (nextNum <= num * num)
        {
            // right    
            for (int i = n; i <= m; i++)
            {
                if (nextNum <= num * num)
                {
                    matrix[i, y] = nextNum;
                    nextNum++;
                    x = i;
                }
            }
            // down
            n++;
            for (int i = n; i <= m; i++)
            {
                if (nextNum <= num * num)
                {
                    matrix[x, i] = nextNum;
                    nextNum++;
                    y = i;
                }
            }
            // left
            m--;
            n--;
            for (int i = m; i >= n; i--)
            {
                if (nextNum <= num * num)
                {
                    matrix[i, y] = nextNum;
                    nextNum++;
                    x = i;
                }
            }
            // up
            n++;
            for (int i = m; i >= n; i--)
            {
                if (nextNum <= num * num)
                {
                    matrix[x, i] = nextNum;
                    nextNum++;
                    y = i;
                }
            }
        }

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write("{0,3}", matrix[j,i]);
            }
            Console.WriteLine();
        }
    }
}