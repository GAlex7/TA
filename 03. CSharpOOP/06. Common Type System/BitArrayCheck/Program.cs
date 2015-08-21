namespace BitArrayCheck
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var arr = new BitArray64(7);
            Console.WriteLine(arr);

            arr[7] = 1;

            Console.WriteLine(arr);
        }
    }
}
