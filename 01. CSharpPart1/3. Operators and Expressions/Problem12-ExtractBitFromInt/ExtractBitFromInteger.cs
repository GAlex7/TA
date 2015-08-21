// Problem 12. Extract Bit from Integer
// Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int bitPos = int.Parse(Console.ReadLine());
        int mask = 1 << bitPos;
        int bit = Convert.ToInt32(num & Convert.ToUInt32(mask)) >> bitPos;
        // Console.WriteLine("{0} -> {1}, p = {2}, bit @ p -> {3}",num, Convert.ToString(num, 2).PadLeft(16, '0'),bitPos, bit);
        Console.WriteLine(bit);
    }
}