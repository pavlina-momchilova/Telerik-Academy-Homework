using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RangeExceptions
{
    public class InvalidRangeException<T>:ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end, string msg)
            : base(String.Format("{0}\nThe parametur must be in range [{1},{2}]",msg,start,end))
        {
            this.Start = start;
            this.End = end;
        }

        public T Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }
       
    }
}
