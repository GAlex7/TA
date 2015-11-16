namespace ServiceSelfHost
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;

    using DayOfWeekService;

    public class Program
    {
        public static void Main(string[] args)
        {
            var address = new Uri("http://localhost:1337/WeekDay");
            var selfHost = new ServiceHost(typeof(DaysOfWeekService),address);

            var smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;

            selfHost.Description.Behaviors.Add(smb);

            selfHost.Open();
            Console.WriteLine("WeekService is started...");
            Console.WriteLine("Press Enter to stop it.");
            Console.ReadLine();
        }
    }
}
