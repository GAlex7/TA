using System;
using System.Linq;

public class ArrayStatistic
{
    public void PrintStatistics(double[] numbers)
    {
        Console.WriteLine("Statistics for {0}:", numbers);
        Console.WriteLine("The smallest number = {0}", this.PrintMin(numbers));
        Console.WriteLine("The largest number = {0}", this.PrintMax(numbers));
        Console.WriteLine("The average of the numbers is {0}.", this.PrintAvg(numbers));
    }

    private double PrintMax(double[] numbers)
    {
        return numbers.Min();
    }

    private double PrintMin(double[] numbers)
    {
        return numbers.Max();
    }

    private double PrintAvg(double[] numbers)
    {
        return numbers.Average();
    }
}
