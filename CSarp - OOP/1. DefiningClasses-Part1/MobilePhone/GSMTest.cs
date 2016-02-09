namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        public void GsmTest()
        {
            // array of few instances of the GSM class
            GSM[] arrayOfGSM =
            {
                new GSM("ONE", "HTC", new Battery(BatteryType.NiCd, 24, 12), new Display(5.5), 900),
                new GSM("G2", "LG", new Battery(BatteryType.NiMH, 30, 20), new Display(5.5), 500),
                new GSM("G3", "LG", new Battery(BatteryType.LiIon), new Display(5.5), 800),
                new GSM("Z3", "Sony", new Battery(BatteryType.NiCd, null, 25), new Display(5.5), 1100),
                new GSM("Z2", "sony", new Battery(BatteryType.NiCd), new Display(5.5), 900),
                new GSM("Xperia", "Sony", new Battery(BatteryType.NiMH), new Display(5.5), 300)
            };

            // Display the information about the GSMs in the array.
            foreach (var item in arrayOfGSM)
            {
                Console.WriteLine(item);
                Console.WriteLine(new string('-', 70));
            }

            // Display the information about the static property IPhone4S.
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}