namespace ConsoleApplication2
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var firstVar = line[1];
            var secondVar = line[3];

            line = Console.ReadLine();
            line = Console.ReadLine(); // I don't know why I have to do this?! but bgCoder....
            var power = int.Parse(line);

            ulong x = 1;
            ulong row = (ulong)power;
            var binominalCoefficients = new ulong[row + 1];
            for (ulong col = 0; col <= row; col++)
            {
                binominalCoefficients[col] = x;
                x = x * (row - col) / (col + 1);
            }

            var result = new StringBuilder();

            result.AppendFormat("({0}^{1})", firstVar, power);
            for (int col = 1; col <= power; col++)
            {
                if (power - col == 0)
                {
                    result.AppendFormat("+({0}^{1})", secondVar, col);
                }
                else
                {
                    result.AppendFormat("+{0}({1}^{2})({3}^{4})", binominalCoefficients[col], firstVar, power - col, secondVar, col);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
