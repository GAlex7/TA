// Problem 3. Sequence n matrix

// We are given a matrix of strings of size N x M. 
// Sequences in the matrix we define as sets of several neighbour elements located on the same line, 
// column or diagonal.
// Write a program that finds the longest sequence of equal strings in the matrix.
// Example:

//matrix    	            result		
//ha	fifi	ho	hi      ha, ha, ha		
//fo	ha	    hi	xx
//xxx	ho	    ha	xx

//matrix	        result  
//s	    qq	s       s, s, s
//pp	pp	s
//pp	qq	s


using System;
using System.Collections.Generic;
using System.Linq;

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Please enter rows of matrix R= ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Please enter columns of matrix C= ");
        int cols = int.Parse(Console.ReadLine());
        string[/* row */,/* col */] matrix = new string[rows, cols];
        //{
        //    {"ha","fifi","ho","hi"},
        //    {"fo","ha","hi","xx"},
        //    {"xxx","ho","ha","gaD"},
        //    {"30","31 ","ga","33 "},
        //    {"40","ga","42 ","43 "},
        //    {"ga","51 ","52 ","53 "}
        //};
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("Please enter row {0} elements of string separated by space:", row);
            string colsLine = Console.ReadLine();
            string[] cells = colsLine.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = cells[col];
            }
        }
        //int rows = matrix.GetLength(0);
        //int cols = matrix.GetLength(1);
        int m = SmallestNumb(rows, cols) - 2; //count of every 4 short diagonals
        int n = Math.Abs(rows - cols) + 1;    //count of every 2 long diagonals
        int shortDiagonals = m * 4;
        int longDiagonals = n * 2;
        int allDiagonals = shortDiagonals + longDiagonals;
        int allSets = m * 4 + n * 2 + rows + cols;

        string[][] jaggedStr = new string[allSets][];

        // define array with positions for each jaggeds
        // on the level 0 it will keep condition
        // on the level 1 it will keep position for next elem 
        int[,] pos = new int[2, allSets];

        // define short diagonals
        int nextArrNumber = 0;
        int condition = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0:
                        {
                            condition = 1 + i;
                            break;
                        }
                    case 1:
                        {
                            condition = m + n - 1 - i;
                            condition *= rows > cols ? -1 : 1;
                            break;
                        }
                    case 2:
                        {
                            condition = 2 * m + n - i;
                            break;
                        }
                    case 3:
                        {
                            condition = m - i;
                            condition *= rows > cols ? 1 : -1;
                            break;
                        }
                    default:
                        break;
                }
                pos[0, nextArrNumber] = condition;
                CreateNextArr(jaggedStr, ref nextArrNumber, i + 2);
            }
        }
        // define long diagonals
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (j == 0)
                {
                    condition = m + 1 + i;
                }
                else
                {
                    condition = n - 1 - i;
                    condition *= rows > cols ? -1 : 1;
                }
                pos[0, nextArrNumber] = condition;
                CreateNextArr(jaggedStr, ref nextArrNumber, SmallestNumb(rows, cols));
            }
        }
        // define rows
        for (int i = 0; i < rows; i++)
        {
            pos[0, nextArrNumber] = i + 1;
            CreateNextArr(jaggedStr, ref nextArrNumber, cols);
        }
        // define cols
        for (int i = 0; i < cols; i++)
        {
            pos[0, nextArrNumber] = i + 1;
            CreateNextArr(jaggedStr, ref nextArrNumber, rows);
        }

        // fill jagged array with diagonal elements
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                for (int i = 0; i < allDiagonals; i++)
                {
                    if ((row + col == pos[0, i] && i % 2 == 0) ||
                        (col - row == pos[0, i] && i % 2 == 1))
                    {
                        // add element in jagged
                        AddToJagged(jaggedStr, pos, i, matrix, row, col);
                    }
                }
            }
        }

        // fill jagged with rows and columns elements
        int jagR, jagC;
        for (int row = 0; row < rows; row++)
        {
            jagR = allDiagonals + row;
            for (int col = 0; col < cols; col++)
            {
                jagC = allDiagonals + rows + col;
                AddToJagged(jaggedStr, pos, jagR, matrix, row, col);
                AddToJagged(jaggedStr, pos, jagC, matrix, row, col);
            }
        }
        string[] longestSequence = { "" };
        for (int i = 0; i < jaggedStr.Length; i++)
        {
            string[] thisSequence = FindSequence(jaggedStr[i]);
            if (longestSequence.Length < thisSequence.Length)
            {
                longestSequence = thisSequence;
            }
        }

        // output
                Console.WriteLine("The longest sequence is: {0}.", 
                                  String.Join(", ", longestSequence));
    }
    static void AddToJagged(string[][] jagArr, int[,] pos, int index, string[,] matrix, int row, int col)
    {
        // add element in jagged
        jagArr[index][pos[1, index]] = matrix[row, col];
        // increase pos for this jagged sequence
        pos[1, index]++;
    }

    static string[] FindSequence(string[] arr)
    {
        string[] newSequence;
        int counter = 1;
        int[] result = new int[arr.Length - 1];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
                result[i] = counter;
            }
            else
            {
                counter = 1;
            }
        }
        counter = result.Max();
        newSequence = new string[counter];
        for (int i = 0; i < counter; i++)
        {
            newSequence[i] = arr[Array.IndexOf(result, counter)];
        }
        return newSequence;
    }

    static void CreateNextArr(string[][] jagged, ref int nextArrNumber, int members)
    {
        jagged[nextArrNumber] = new string[members];
        nextArrNumber++;
    }

    static int SmallestNumb(int r, int c)
    {
        return r > c ? c : r;
    }
}