namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSMTest
    {
        public void Test()
        {
            List<GSM> mobileDevices = new List<GSM>();
            mobileDevices.Add(new GSM("Galaxy S5","Smasung",1200.00M,"Jhon Smith",new Battery("Samsung",BatteryType.Li_ion,400.00,20.00),new Display(5.3,16000000)));
            mobileDevices.Add(new GSM("One M8 ", "HTC", 1200.00M, "Hulit Fouck", new Battery("HTC", BatteryType.Li_poly, 496.00, 20.00), new Display(5.0, 16000000)));
            mobileDevices.Add(new GSM("Mi 4", "Xiaomi", 800.00M, null, new Battery("Xiaomi", BatteryType.Li_ion, 280.00, 10.00), new Display(5.0, 16000000)));

            foreach (GSM phone in mobileDevices)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine();
            }
            Console.WriteLine(GSM.IPhone4S.ToString());

        }
    }
}
