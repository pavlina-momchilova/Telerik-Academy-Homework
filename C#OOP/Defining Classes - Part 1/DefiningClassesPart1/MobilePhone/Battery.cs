namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Battery
    {
        private string model;
        private BatteryType? batteryType;
        private double? hoursIdle;
        private double? hoursTalk;

        public Battery(string model)
            : this(model, null)
        {

        }

        public Battery(string model, BatteryType? batteryType)
            : this(model, batteryType, null)
        {

        }

        public Battery(string model, BatteryType? batteryType, double? hoursIdle)
            : this(model, batteryType, hoursIdle, null)
        {
        }

        public Battery(string model, BatteryType? batteryType, double? hoursIdle, double? hoursTalk)
        {
            this.Model = model;
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
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
                    throw new ArgumentException("You have to enter battery's model!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public BatteryType? BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }


        public override string ToString()
        {
            return String.Format("\n   - Model : {0}\n   - Type : {1}\n   - Idle hours : {2}\n   - Talk hours : {3}",
                this.model, this.batteryType.ToString() ?? "[unknown]",
                this.hoursIdle.ToString() ?? "[unknown]", this.hoursTalk.ToString() ?? "[unknown]"); // enum bla bla 
        }

    }
}
