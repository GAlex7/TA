namespace RangeException
{
    using System;

    public class Check
    {
        public static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid range!", 1, 10);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date range!", new DateTime(1971, 1, 1), new DateTime(2015, 3, 26));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
