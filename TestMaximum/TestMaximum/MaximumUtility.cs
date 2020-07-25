﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class MaximumUtility
    {
        public int FindMaximumNumber(int XNumber, int YNumber, int ZNumber)
        {
            int maximum = XNumber;
            if (maximum.CompareTo(YNumber) < 0)
                maximum = YNumber;
            if (maximum.CompareTo(ZNumber) < 0)
                maximum = ZNumber;
            return maximum;
        }
    }
}
