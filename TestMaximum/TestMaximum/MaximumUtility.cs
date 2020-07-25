using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class MaximumUtility
    {
        

        public E FindMaximumNumber<E>(E XNumber, E YNumber, E ZNumber) where E : IComparable
        {
            E maximum = XNumber;
            if (maximum.CompareTo(YNumber) < 0)
                maximum = YNumber;
            if (maximum.CompareTo(ZNumber) < 0)
                maximum = ZNumber;
            return maximum;
        }
        //public float FindMaximumNumber(float XNumber, float YNumber, float ZNumber)
        //{
        //    float maximum = XNumber;
        //    if (maximum.CompareTo(YNumber) < 0)
        //        maximum = YNumber;
        //    if (maximum.CompareTo(ZNumber) < 0)
        //        maximum = ZNumber;
        //    return maximum;
        //}
        //public string FindMaximumNumber(string XNumber, string YNumber, string ZNumber)
        //{
        //    string maximum = XNumber;
        //    if (maximum.CompareTo(YNumber) < 0)
        //        maximum = YNumber;
        //    if (maximum.CompareTo(ZNumber) < 0)
        //        maximum = ZNumber;
        //    return maximum;
        //}
    }
}
