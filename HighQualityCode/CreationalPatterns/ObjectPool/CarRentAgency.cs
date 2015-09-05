namespace ObjectPool
{
    using System;
    using System.Collections.Generic;

    public class CarRentAgency<T> where T : IDisposable, new()
    {
        private readonly List<T> availableCars = new List<T>();
        private readonly List<T> usedCars = new List<T>();

        public CarRentAgency()
        {
        }

        public T RentACar()
        {
            lock (this.availableCars)
            {
                if (this.availableCars.Count != 0)
                {
                    var car = this.availableCars[0];
                    this.usedCars.Add(car);
                    this.availableCars.RemoveAt(0);
                    return car;
                }
                else
                {
                    var car = new T();
                    this.usedCars.Add(car);
                    return car;
                }
            }
        }

        public void ReleaseCar(T car)
        {
            car.Dispose();

            lock (this.availableCars)
            {
                this.availableCars.Add(car);
                this.usedCars.Remove(car);
            }
        }
    }
}
