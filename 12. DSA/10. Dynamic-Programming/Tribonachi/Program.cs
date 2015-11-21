namespace SuperSum
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine(); // "2 3 4 5";

            var numbers = input.Split(' ');

            var t1 = long.Parse(numbers[0]);
            var t2 = long.Parse(numbers[1]);
            var t3 = long.Parse(numbers[2]);
            var n = long.Parse(numbers[3]);

            if (n < 4)
            {
                Console.WriteLine(numbers[n - 1]);
            }
            else
            {
                long result = 0;

                for (int i = 0; i < n - 3; i++)
                {
                    result = t1 + t2 + t3;
                    t1 = t2;
                    t2 = t3;
                    t3 = result;
                }

                Console.WriteLine(result);
            }
        }
    }
}
