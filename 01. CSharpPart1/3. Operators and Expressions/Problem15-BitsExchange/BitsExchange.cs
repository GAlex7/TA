// Problem 15.* Bits Exchange
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class BitsExchange
{
    static void Main()
    {
        int p = 3;
        int q = 24;
        int k = 3;
        Console.Write("N = ");
        uint num = uint.Parse(Console.ReadLine());
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