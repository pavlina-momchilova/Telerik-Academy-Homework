namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialledPhoneNum;
        private int duration;

        public Call(DateTime date,DateTime time, string dialledPhoneNum,int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhoneNum = dialledPhoneNum;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date; 
            }
            set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public string DialledPhoneNum
        {
            get
            {
                return this.dialledPhoneNum;
            }
            set
            {
                this.dialledPhoneNum = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return String.Format("\n History: \n date:{0:d} \n time:{1:t} \n Dialed Phone Numbers:{2} \n Duration:{3} ",Date,Time,DialledPhoneNum,Duration);
        }
    }
}
