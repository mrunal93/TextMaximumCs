using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class MaximumUtility<E> where E : IComparable
    {
        E XNumber;
        E YNumber;
        E ZNumber;

        public MaximumUtility(E XNumber, E YNumber, E ZNumber)
        {
            this.XNumber = XNumber;
            this.YNumber = YNumber;
            this.ZNumber = ZNumber;
        }

        public E FindMaximumNumber()
        {
            E maximum = XNumber;
            if (maximum.CompareTo(YNumber) < 0)
                maximum = YNumber;
            if (maximum.CompareTo(ZNumber) < 0)
                maximum = ZNumber;
            return maximum;
        }
    }
}