namespace MobilePhone
{
    using System;

    public class GSMCallHistoryTest
    {
        public void GsmCallHistoryTest()
        {
            GSM gsm = new GSM();
            gsm.AddCalls(new Call("12.05.2015", "23:52:31", "+359869256543", 60));
            gsm.AddCalls(new Call("03.06.2015", "13:42:32", "+359849213553", 32));
            gsm.AddCalls(new Call("24.05.2015", "14:52:33", "+359899228563", 60));
            gsm.AddCalls(new Call("15.03.2015", "12:22:34", "+359889237573", 660));
            gsm.AddCalls(new Call("26.07.2015", "10:32:35", "+359989246523", 60));
            gsm.AddCalls(new Call("17.03.2015", "08:12:36", "+359889255529", 32));
            gsm.AddCalls(new Call("08.02.2015", "02:32:37", "+359889264503", 56));
            gsm.AddCalls(new Call("29.08.2015", "23:52:37", "+359889273593", 120));

            int theLongestCall = 0;
            int index = 0;

            if (gsm.HistoryCall.Count != 0)
            {
                for (int i = 0; i < gsm.HistoryCall.Count; i++)
                {
                    Console.WriteLine(gsm.HistoryCall[i]);

                    if (gsm.HistoryCall[i].Duration > theLongestCall)
                    {
                        theLongestCall = gsm.HistoryCall[i].Duration;
                        index = i;
                    }

                    Console.WriteLine(new string('-', 70));
                }
            }
            else
            {
                Console.WriteLine("The call history is empty");
            }

            Console.WriteLine("Total price of the calls in the call history is: {0}", gsm.TotalPriceOfTheCallHistory(0.37M));

            gsm.DeleteCalls(index);
            Console.WriteLine(new string('-', 70));
            Console.WriteLine("After remove the longest call:");
            Console.WriteLine("Total price of the calls in the call history is: {0}", gsm.TotalPriceOfTheCallHistory(0.37M));
            Console.WriteLine(new string('-', 70));

            gsm.ClearCallHistory();

            if (gsm.HistoryCall.Count != 0)
            {
                foreach (var item in gsm.HistoryCall)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("The call history is empty");
            }
        }
    }
}