// Problem 14. Modify a Bit at Given Position
// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at 
// the position p from the binary representation of n while preserving all other bits in n.

using System;
class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("N = ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        if (v == 1)
        {
            num = num | mask;
        }
        else
        {
            num = num & ~mask;
        }
        Console.WriteLine(num);
    }
}