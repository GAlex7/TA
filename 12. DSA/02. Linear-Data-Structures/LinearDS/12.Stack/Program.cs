namespace Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1, 2, 3, 4, 5, 4, 3);

            while (stack.Length > 0)
            {
                if (stack.Length > 1)
                {
                    Console.Write("{0}, ", stack.Pop());
                }
                else
                {
                    Console.WriteLine(stack.Pop());
                }
            }

            Console.WriteLine();
        }
    }
}
