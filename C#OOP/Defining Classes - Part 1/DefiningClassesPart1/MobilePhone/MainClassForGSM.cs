
namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClassForGSM
    {
        static void Main()
        {
            Console.WriteLine("GSM Test:");
            GSMTest testGSM = new GSMTest();
            testGSM.Test();
            Console.WriteLine();
            Console.WriteLine("GSM Call history test: ");
            CallHistoryTest testCallHistory = new CallHistoryTest();
            testCallHistory.Test();
        }
    }
}
