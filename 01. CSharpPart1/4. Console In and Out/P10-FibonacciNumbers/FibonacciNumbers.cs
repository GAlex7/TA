// Problem 10. Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n members 
// of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
// Note: You may need to learn how to use loops.

using System;
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int fibNumbPrev = 0;
        int fibNumb = 0;
        int fibNumbNext = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", fibNumb);
            fibNumbPrev = fibNumb;
            fibNumb = fibNumbNext;
            fibNumbNext = fibNumbPrev + fibNumb;
        }
    }
}