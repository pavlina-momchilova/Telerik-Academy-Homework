namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GSM
    {

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        private static readonly GSM iPhone4S = new GSM
            ("iPhone 4S", "Apple", 765.00M, null,
            new Battery("Apple", BatteryType.Li_poly, 200, 14)
            , new Display(4.7, 16000000));

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("You have to enter phone's model!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("You have to enter phone's model!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal? Price
        {
            get
            {
                return (decimal)this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
           
        }

        public void addCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void RemoveCall(Call call)
        {
            int index = callHistory.IndexOf(call);
            if (index != -1)
            {
                callHistory.RemoveAt(index);
            }
        }
        public void ClearHistory()
        {
            callHistory.RemoveRange(0,callHistory.Count);
        }

        public decimal TotalPrice(decimal pricePerMinute)
        {
            decimal totalPrice = 0;
            foreach (var call in callHistory)
            {
                totalPrice += call.Duration * pricePerMinute;
            }
            return totalPrice;
        }
        public override string ToString()
        {
            return String.Format("Model : {0}\nManufacturer : {1}\nPrice : {2}\nOwner : {3} \nBattery : {4}\nDisplay : {5}",
                this.model, this.manufacturer, this.price.ToString() ?? "[unknown]", this.owner ?? "[unknown]",
                this.battery.ToString(), this.display.ToString() ?? "[unknown]");
        }

    }
}
