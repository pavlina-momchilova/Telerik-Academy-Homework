namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CallHistoryTest
    {
        private GSM divaice = new GSM("Galaxy Note 3", "Smasung", 1200.00M, null, new Battery("Samsung", BatteryType.Li_ion, 410.00, 25.00), new Display(5.7, 16000000));
        public void Test()
        {
            divaice.addCall(new Call(new DateTime(2015, 05, 27), new DateTime(2015, 07, 27, 13, 22, 12), "+359 445 874 254", 520));
            divaice.addCall(new Call(new DateTime(2015, 05, 27), new DateTime(2015, 06, 02, 12, 00, 40), "+359 105 574 794", 50));
            divaice.addCall(new Call(new DateTime(2015, 05, 27), new DateTime(2015, 05, 13, 20, 23, 09), "+359 845 774 851", 1520));
            divaice.addCall(new Call(new DateTime(2015, 05, 27), new DateTime(2015, 04, 12, 21, 16, 10), "+359 888 872 699", 5230));
            divaice.addCall(new Call(new DateTime(2015, 05, 27), new DateTime(2015, 03, 01, 01, 55, 00), "+359 111 111 125", 10));

            foreach (var call in divaice.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }

            Console.WriteLine("The price of the calls is: " + divaice.TotalPrice(0.37M));
            int finalMax = 0;
            int index=0;
            int max = divaice.CallHistory[0].Duration;
            for (int i = 0; i < divaice.CallHistory.Count; i++)
            {
                if (max < divaice.CallHistory[i].Duration)
                {
                    max = divaice.CallHistory[i].Duration;
                    if (max > finalMax)
                    {
                        finalMax = max;
                        index=i;
                    }
                }
            }
            divaice.CallHistory.RemoveAt(index);
            Console.WriteLine("The price of the calls is: " + divaice.TotalPrice(0.37M));
            divaice.ClearHistory();
            Console.WriteLine("History: ");
            foreach (var call in divaice.CallHistory)
            {
                Console.WriteLine(call);
            }

        }

    }
}
