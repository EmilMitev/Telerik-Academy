namespace _02.DaysOfWeek.Client
{
    using System;
    using _02.DaysOfWeek.Client.DayOfWeekService;

    public class Startup
    {
        static void Main()
        {
            DaysOfWeekServiceClient service = new DaysOfWeekServiceClient();
            Console.WriteLine(service.GetData(DateTime.Now));
        }
    }
}
