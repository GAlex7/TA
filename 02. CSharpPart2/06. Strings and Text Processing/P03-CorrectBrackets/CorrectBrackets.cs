// Problem 3. Correct brackets

// Write a program to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

namespace P03_CorrectBrackets
{
    using System;
    using System.Text;

    class CorrectBrackets
    {
        static bool IsBracketsOk(string text)
        {
            int lastOpenBr = 0;
            int nextCloseBr = 0;
            while (nextCloseBr != -1)
            {
                lastOpenBr = text.LastIndexOf('(');
                nextCloseBr = text.IndexOf(')', lastOpenBr == -1 ? 0 : lastOpenBr);
                if (nextCloseBr == -1)
                    if (lastOpenBr == -1)
                        return true;
                    else return false;
                else
                {
                    text = text.Remove(lastOpenBr, 1);
                    text = text.Remove(nextCloseBr - 1, 1);
                }
            }
            return true;
        }
        static void Main()
        {
            Console.Write("Enter an expression with brackets: ");
            string input = "()(())"; Console.ReadLine();
            Console.WriteLine("The brackets " + (IsBracketsOk(input)?"are ":"aren't ") + "correct!");
        }
    }
}
