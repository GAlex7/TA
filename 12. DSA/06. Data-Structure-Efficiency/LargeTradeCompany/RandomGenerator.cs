namespace LargeTradeCompany
{
    using System;
    using System.Text;

    public static class RandomGenerator
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private static Random random = new Random();

        public static int GetRandomNumber(int min = 0, int max = int.MaxValue / 2)
        {
            return random.Next(min, max + 1);
        }

        public static string GetRandomText(int minLength = 0, int maxLength = int.MaxValue / 2)
        {
            var len = GetRandomNumber(minLength, maxLength);

            var result = new StringBuilder();

            for (int i = 0; i < len; i++)
            {
                result.Append(Alphabet[GetRandomNumber(0, Alphabet.Length - 1)]);
            }

            return result.ToString();
        }

        public static DateTime GetRandomDate(DateTime? after = null, DateTime? before = null)
        {
            var minDate = after ?? new DateTime(1900, 1, 1, 0, 0, 0);
            var maxDate = before ?? new DateTime(2100, 12, 31, 23, 59, 59);

            var seconds = GetRandomNumber(0, 59);
            var minutes = GetRandomNumber(0, 59);
            var hours = GetRandomNumber(0, 23);
            var day = GetRandomNumber(minDate.Day, maxDate.Day);
            var month = GetRandomNumber(minDate.Month, maxDate.Month);
            var year = GetRandomNumber(minDate.Year, maxDate.Year);

            if (day > 28)
            {
                day = 28;
            }

            return new DateTime(year, month, day, hours, minutes, seconds);
        }
    }
}
