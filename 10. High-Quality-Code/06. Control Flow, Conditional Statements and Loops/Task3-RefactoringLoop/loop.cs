using System;

namespace Task3_RefactoringLoop
{
    class Loop
    {
        static void Main()
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
