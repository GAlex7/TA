namespace ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ServiceModel;
    using TextTimes;

    public class Program
    {
        public static void Main()
        {
            var client = new NumberOfTimesServiceClient();
            Console.WriteLine(client.GetCounts("ala bala nica", "ala"));
        }
    }
}
