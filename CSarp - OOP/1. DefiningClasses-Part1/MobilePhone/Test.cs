namespace MobilePhone
{
    using System;

    public class Test
    {
        public static void Main()
        {
            GSMTest gsmTest = new GSMTest();
            gsmTest.GsmTest();
            Console.WriteLine(new string('*', 80));
            Console.WriteLine(new string('*', 80));
            Console.WriteLine(new string('*', 80));
            GSMCallHistoryTest historyTest = new GSMCallHistoryTest();
            historyTest.GsmCallHistoryTest();
        }
    }
}