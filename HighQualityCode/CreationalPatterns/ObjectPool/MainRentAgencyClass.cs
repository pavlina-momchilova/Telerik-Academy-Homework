namespace ObjectPool
{
    using System;
    using System.Threading;

    public class MainRentAgencyClass
    {
        public static void Main()
        {
            var carRentAgency = new CarRentAgency<Car>();

            var renault = carRentAgency.RentACar();
            renault.Employee = "Petur";
            Console.WriteLine(
                "Renault rent on {0:MM/dd/yyyy hh:mm:ss.fff tt} used by {1}",
                renault.RentOn,
                renault.Employee);
            Thread.Sleep(2000);

            var opel = carRentAgency.RentACar();
            opel.Employee = "Ivan";
            Console.WriteLine(
                "Opel rent on {0:MM/dd/yyyy hh:mm:ss.fff tt} used by {1}",
                opel.RentOn,
                opel.Employee);
            Thread.Sleep(2000);

            carRentAgency.ReleaseCar(renault);
        }
    }
}
