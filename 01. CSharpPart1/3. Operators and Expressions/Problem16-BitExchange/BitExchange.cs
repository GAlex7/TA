// Problem 16.** Bit Exchange
// Write a program that exchanges bits {p, p+1, …, p+k-1} 
// with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

using System;
class BitExchange
{
    static void Main()
    {
        Console.Write("N = ");
        uint num = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        //Console.WriteLine();
        Console.WriteLine("N     -> {0}", Convert.ToString(num, 2).PadLeft(32, '0'));
        for (int i = 0; i < k; i++)
        {
            int maskP = 1 << (p + i);
            int bitP = ((int)num & maskP) >> (p + i);

            //Console.WriteLine("maskP -> {0}", Convert.ToString(maskP, 2).PadLeft(32, '0'));

            int maskQ = 1 << (q + i);
            int bitQ = ((int)num & maskQ) >> (p + i);

            //Console.WriteLine("maskQ -> {0}", Convert.ToString(maskQ, 2).PadLeft(32, '0'));

            int bit = bitP;
            if (bitQ == 0)
            {
                num = num & ~(uint)maskP;
            }
            else
            {
                num = num | (uint)maskP;
            }

            if (bit == 0)
            {
                num = num & ~(uint)maskQ;
            }
            else
            {
                num = num | (uint)maskQ;
            }
            //Console.WriteLine("N     -> {0}", Convert.ToString(num, 2).PadLeft(32, '0'));
        }
        Console.WriteLine("N     -> {0}", Convert.ToString(num, 2).PadLeft(32, '0'));

        Console.WriteLine(num);
    }
}