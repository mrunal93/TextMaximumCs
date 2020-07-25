using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace TestMaximum
{
    public class MaximumUtility<E>
    {
        E[] inputValue;

        public E FindMaximumNumber(params E[] inputValue) 
        {
            Array.Sort(inputValue);
            int maximum = inputValue.Length - 1;
            return inputValue[maximum];
            
        }   
    }

}