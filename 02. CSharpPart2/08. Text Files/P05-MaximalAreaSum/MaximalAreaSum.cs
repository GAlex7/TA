// Problem 5. Maximal area sum

// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.
// Example:

// input	    output
// 4 
// 2 3 3 4 
// 0 2 3 4 
// 3 7 1 2 
// 4 3 3 2	    17

namespace P05_MaximalAreaSum
{
    using System;
    using System.IO;

    class MaximalAreaSum
    {
        static void Main()
        {
            int n = 0;
            int areaDim = 2;
            using (StreamReader reader = new StreamReader(@"..\..\InputTest.txt"))
            {
                string line = reader.ReadLine();
                n = int.Parse(line);
                int[,] matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    line = reader.ReadLine();
                    string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(input[j]);
                    }
                }
                Console.WriteLine(FindMaxAreaSum(matrix, areaDim));
            }
        }

        private static int FindMaxAreaSum(int[,] matrix, int n)
        {
            int maxRes = 0;
            for (int r = 0; r < matrix.GetLength(0) - n + 1; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - n + 1; c++)
                {
                    if (SubSum(matrix, r, c) > maxRes)
                    {
                        maxRes = SubSum(matrix, r, c);
                    }
                }
            }
            return maxRes;
        }

        private static int SubSum(int[,] matrix, int r, int c)
        {
            int sum = 0;
            for (int i = r; i < r + 2; i++)
            {
                for (int j = c; j < c + 2; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}