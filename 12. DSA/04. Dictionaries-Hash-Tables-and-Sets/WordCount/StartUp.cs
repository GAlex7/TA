namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var fileName = "../../words.txt";

            var text = File.ReadAllText(fileName);
            var words = text.Split(new[] { ' ', ',', '?', '.', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var wordLowerCase = word.ToLower();
                if (!dict.ContainsKey(wordLowerCase))
                {
                    dict.Add(wordLowerCase, 0);
                }

                dict[wordLowerCase] += 1;
            }

            var sortedDictByValue = dict.OrderBy(x => x.Value);

            foreach (var word in sortedDictByValue)
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }
    }
}
