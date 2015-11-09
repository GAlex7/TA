namespace LargeTradeCompany
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Program
    {
        public static void Main()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(true);
            var articlesCount = 100;

            for (int i = 0; i < articlesCount; i++)
            {
                var price = RandomGenerator.GetRandomNumber(10, 10000);
                articles.Add(
                    price,
                    new Article(
                        RandomGenerator.GetRandomText(13, 13),
                        RandomGenerator.GetRandomText(3, 5),
                        RandomGenerator.GetRandomText(5, 10),
                        price));
            }

            var result = articles.Range(50M, true, 1500, true).SelectMany(a => a.Value);

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
