using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 11; i++)
        {
            Console.Write(i * Math.Pow(-1, i) + ", ");
        }
    }
}