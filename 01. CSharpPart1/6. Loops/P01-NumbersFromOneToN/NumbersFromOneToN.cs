﻿// Problem 1. Numbers from 1 to N
// Write a program that enters from the console a positive integer n and 
// prints all the numbers from 1 to n, on a single line, separated by a space.

using System;
class NumbersFromOneToN
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            Console.Write("{0} ",i+1);
        }

    }
}