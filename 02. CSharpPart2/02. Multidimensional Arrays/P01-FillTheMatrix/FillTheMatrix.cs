// Problem 1. Fill the matrix

// Write a program that fills and prints a matrix of size (n, n) as shown below:
// Example for n=4:

//  a)	            b)	            c)          	d)*
//  1  5  9 13      1  8  9 16      7 11 14 16      1 12 11 10
//  2  6 10 14      2  7 10 15      4  8 12 15      2 13 16  9
//  3  7 11 15      3  6 11 14      2  5  9 13      3 14 15  8   
//  4  8 12 16      4  5 12 13      1  3  6 10      4  5  6  7

using System;
using System.Collections.Generic;
using System.Linq;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Program that fills and prints a matrix of size (n, n).");
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int next = 1;

        // a)
        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                arr[y, x] = next;
                next++;
            }
        }
        Console.WriteLine("a)");
        PrintToConsole(n, arr);

        // b)
        next = 1;
        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                if (y % 2 == 1)
                {
                    arr[y, x] = n * (y + 1) - x;
                }
                else
                {
                    arr[y, x] = n * y + x + 1;
                }
            }
        }
        Console.WriteLine("b)");
        PrintToConsole(n, arr);

        // c)
        int xx = 0, yy = n - 1;
        next = 1;
        arr[xx, yy] = next; next++;
        while (next <= n * n)
        {
            xx++;
            yy++;
            if (xx == n || yy == n)
            {
                if (yy > xx)
                {
                    yy = n - xx - 1;
                    xx = 0;
                }
                else
                {
                    xx = n - yy + 1;
                    yy = 0;
                }
            }
            arr[xx, yy] = next;
            next++;
        }

        Console.WriteLine("c)");
        PrintToConsole(n, arr);

        // d)*
        xx = 0;
        yy = 0;
        next = 1;
        int startPos = 0; // start position
        int endPos = n - 1; // end position 

        while (next <= n * n)
        {
            // right    
            for (int i = startPos; i <= endPos; i++)
            {
                if (next <= n * n)
                {
                    arr[yy, i] = next;
                    next++;
                    xx = i;
                }
            }
            // down
            startPos++;
            for (int i = startPos; i <= endPos; i++)
            {
                if (next <= n * n)
                {
                    arr[i, xx] = next;
                    next++;
                    yy = i;
                }
            }
            // left
            endPos--;
            startPos--;
            for (int i = endPos; i >= startPos; i--)
            {
                if (next <= n * n)
                {
                    arr[yy, i] = next;
                    next++;
                    xx = i;
                }
            }
            // up
            startPos++;
            for (int i = endPos; i >= startPos; i--)
            {
                if (next <= n * n)
                {
                    arr[i, xx] = next;
                    next++;
                    yy = i;
                }
            }
        }
        Console.WriteLine("d)*");
        PrintToConsole(n, arr);
    }

    private static void PrintToConsole(int n, int[,] arr)
    {
        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                Console.Write("{0,3}", arr[x, y]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}