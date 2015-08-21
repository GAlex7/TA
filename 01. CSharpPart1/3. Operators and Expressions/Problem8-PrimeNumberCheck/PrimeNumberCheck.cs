// Problem 8. Prime Number Check
// Write an expression that checks if given positive integer number n (n <= 100) is prime 
// (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;
class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please enter a positive integer N (N <= 100) : ");
        byte num = byte.Parse(Console.ReadLine());
        byte divider = 2;
        bool isPrime = true;
        bool isDivider = false;
        bool isDividerLarger = false;
        while (isPrime && !isDividerLarger)
        {
            isDivider = (num % divider) == 0;
            isDividerLarger = divider == num - 1;
            isPrime = !isDivider;
            divider++;
        }
        Console.WriteLine("Is the number {0} prime? --> {1}.", num, isPrime);
    }
}