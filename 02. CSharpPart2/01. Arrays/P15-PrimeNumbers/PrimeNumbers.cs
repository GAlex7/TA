// Problem 15. Prime numbers

// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        int maxPrime = 1000;
        bool isEnd = false;
        int[] primes = new int[maxPrime];

        for (int i = 0; i < maxPrime; i++)
        {
            primes[i] = i + 2;
        }
        int index = 0;

        while (index <= maxPrime && !isEnd)
        {
            for (int i = index + primes[index]; i < maxPrime; i += primes[index])
            {
                primes[i] = 0;
            }

            do
            {
                index++;
                if (index == maxPrime)
                {
                    isEnd = true;
                    break;
                }
            } while (primes[index] == 0);
            if (!isEnd)
            {
                for (int i = index + primes[index]; i < maxPrime; i += primes[index])
                {
                    primes[i] = 0;
                }
            }
        }
        // output
        for (int i = 0; i < maxPrime; i++)
        {
            if (primes[i] != 0)
            {
                Console.Write("{0}, ", primes[i]);
            }
        }
        Console.WriteLine();
    }
}