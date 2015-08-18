namespace _03.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public delegate void TimerDelegat();

    public class Timer
    {
        /*
            Problem 7. Timer

            Using delegates write a class Timer that can execute certain method at each t seconds.
         */
        private int timeInterval;
        private TimerDelegat td;

        public Timer(int timeInterval)
        {
            this.TimeInterval = timeInterval;
        }

        public TimerDelegat Td
        {
            get
            {
                return this.td;
            }
            set
            {
                this.td = value;
            }
        }
        public int TimeInterval
        {
            get
            {
                return this.timeInterval;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong interval");
                }
                this.timeInterval = value;
            }
        }

        public void ExecutionOfTimer()
        {
            while (true)
            {
                this.td();
                Thread.Sleep(this.timeInterval * 1000);
            }
        }
    }
}
