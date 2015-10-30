namespace ShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = "5 16";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var numbers = Console.ReadLine()
                            .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(n => int.Parse(n))
                            .ToList();

            var startNumb = numbers[0];
            var targetNumb = numbers[1];

            var reversedQueue = new Queue<int>();
            reversedQueue.Enqueue(targetNumb);

            var currentNumb = targetNumb;

            while (currentNumb > startNumb)
            {
                if ((currentNumb - startNumb) > 4
                    && (startNumb * 2) <= currentNumb)
                {
                    if (currentNumb % 2 == 0)
                    {
                        currentNumb /= 2;
                        reversedQueue.Enqueue(currentNumb);
                    }
                    else
                    {
                        currentNumb -= 1;
                        reversedQueue.Enqueue(currentNumb);
                    }
                }
                else if (currentNumb - startNumb >= 2)
                {
                    currentNumb -= 2;
                    reversedQueue.Enqueue(currentNumb);
                }
                else
                {
                    currentNumb -= 1;
                    reversedQueue.Enqueue(currentNumb);
                }
            }

            var sequence = new List<int>();
            while (reversedQueue.Count > 0)
            {
                sequence.Add(reversedQueue.Dequeue());
            }

            Console.WriteLine("Shortest sequence with {0} moves is: \n{1}", sequence.Count, string.Join(", ", sequence.OrderBy(x => x).ToList()));
        }
    }
}
