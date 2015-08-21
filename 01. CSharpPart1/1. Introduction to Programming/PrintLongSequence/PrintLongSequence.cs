using System;

class PrintLongSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 1001; i++)
        {
            Console.Write(i * Math.Pow(-1, i) + ", ");
        }
    }
}