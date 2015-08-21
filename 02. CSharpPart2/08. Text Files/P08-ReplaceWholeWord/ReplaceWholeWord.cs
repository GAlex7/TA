// Problem 8. Replace whole word

// Modify the solution of the previous problem to replace only whole words (not strings).

namespace P08_ReplaceWholeWord
{
    using System;
    using System.IO;
    using System.Text;

    class ReplaceWholeWord
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            string wordToReplace = "start";
            string newWord = "finish";
            using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    text.AppendLine(ReplaceWords(line, wordToReplace, newWord));
                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(text.ToString());
            }
            Console.WriteLine("The problem is solved and result is in new file -> output.txt .");
        }

        private static string ReplaceWords(string line, string wordToReplace, string newWord)
        {
            int startPos = line.IndexOf(wordToReplace);

            bool isFirstWord;
            bool isLastWord;
            bool isPrevCharLetter;
            bool isNextCharLeter;

            while (startPos != -1)
            {
                isFirstWord = (startPos == 0);
                isLastWord = (startPos + wordToReplace.Length >= line.Length);
                isNextCharLeter = !isLastWord ? (char.IsLetter(line[startPos + wordToReplace.Length])) : false;
                isPrevCharLetter = !isFirstWord ? (char.IsLetter(line[startPos - 1])) : false;

                if ((isFirstWord && (isLastWord || !isNextCharLeter)) ||
                   (!isPrevCharLetter && (isLastWord || !isNextCharLeter)))
                {
                    line = line.Remove(startPos, wordToReplace.Length);
                    line = line.Insert(startPos, newWord);
                }
                startPos = line.IndexOf(wordToReplace, startPos + 1);
            }

            return line;
        }

    }
}
