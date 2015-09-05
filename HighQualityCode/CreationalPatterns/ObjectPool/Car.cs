namespace ObjectPool
{
    using System;

    public class Car : IDisposable
    {
        private readonly DateTime rentOn = DateTime.Now;

        public DateTime RentOn
        {
            get
            {
                return this.rentOn;
            }
        }

        public string Employee { get; set; }

        public void Dispose()
        {
            this.Employee = null;
        }
    }
}
