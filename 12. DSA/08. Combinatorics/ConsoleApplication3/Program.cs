namespace BinaryPasswords
{
    using System;
    using System.Linq;

    public class StarUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int pow = input.Where(a => a == '*').Count();

            long baseN = 2;
            long result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= baseN;
            }

            Console.WriteLine(result);
        }
    }
}