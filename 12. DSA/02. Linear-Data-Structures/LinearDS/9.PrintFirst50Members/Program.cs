namespace PrintFirst50Members
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            // TODO Comment next 3 lines :)
            var input = "2";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var firstNumb = int.Parse(Console.ReadLine());

            var finalQueue = new Queue<int>();
            var membersQueue = new Queue<int>();

            var counter = 1;
            finalQueue.Enqueue(firstNumb);
            membersQueue.Enqueue(firstNumb);

            while (counter < 50)
            {
                var currNumb = membersQueue.Dequeue();

                var nextNumb = currNumb + 1;
                finalQueue.Enqueue(nextNumb);
                membersQueue.Enqueue(nextNumb);

                nextNumb = (currNumb * 2) + 1;
                finalQueue.Enqueue(nextNumb);
                membersQueue.Enqueue(nextNumb);

                nextNumb = currNumb + 2;
                finalQueue.Enqueue(nextNumb);
                membersQueue.Enqueue(nextNumb);

                counter += 3;
            }

            for (int i = 0; i < 50; i++)
            {
                if (i != 49)
                {
                    Console.Write("{0}, ", finalQueue.Dequeue());
                }
                else
                {
                    Console.WriteLine("{0}.", finalQueue.Dequeue());
                }
            }
        }
    }
}
