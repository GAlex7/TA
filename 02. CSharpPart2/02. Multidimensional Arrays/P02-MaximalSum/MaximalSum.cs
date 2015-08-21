// Problem 2. Maximal sum

// Write a program that reads a rectangular matrix of size N x M and 
// finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        int colsNewMatrix = 3;
        Console.Write("Please enter rows of matrix R= ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Please enter columns of matrix C= ");
        int cols = int.Parse(Console.ReadLine());
        int[/* row */,/* col */] matrix = new int[rows, cols];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("Please enter row {0} elements separated by space:", row);
            string colsLine = Console.ReadLine();
            string[] cells = colsLine.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(cells[col]);
            }
        }
        int bestSum = 0;
        for (int i = 0; i < colsNewMatrix; i++)
        {
            for (int j = 0; j < colsNewMatrix; j++)
            {
                bestSum += matrix[j, i];
            }
        }
        int newSum;
        int x = 0, y = 0;
        for (int row = 0; row <= matrix.GetLength(0) - colsNewMatrix; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - colsNewMatrix; col++)
            {
                newSum = 0;
                for (int i = 0; i < colsNewMatrix; i++)
                {
                    for (int j = 0; j < colsNewMatrix; j++)
                    {
                        newSum += matrix[row + j, col + i];
                    }

                }
                if (newSum > bestSum)
                {
                    bestSum = newSum;
                    x = col;
                    y = row;
                }
            }
        }
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Best sum = {0} and it's left corner is [{1}, {2}].", bestSum, y, x);
    }
}