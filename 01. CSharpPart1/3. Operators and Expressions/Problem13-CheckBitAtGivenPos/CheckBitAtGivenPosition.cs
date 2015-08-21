// Problem 13. Check a Bit at Given Position
// Write a Boolean expression that returns if the bit at position p 
// (counting from 0, starting from the right) in given integer number n, has value of 1.


using System;
class CheckBitAtGivenPosition
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int bitPos = int.Parse(Console.ReadLine());
        int mask = 1 << bitPos;
        int bit = Convert.ToInt32(num & Convert.ToUInt32(mask)) >> bitPos;
        // Console.WriteLine("{0} -> {1}, p = {2}, bit @ p -> {3}",num, Convert.ToString(num, 2).PadLeft(16, '0'),bitPos, bit);
        Console.WriteLine(bit==1);
    }
}