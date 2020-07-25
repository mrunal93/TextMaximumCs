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

        public MaximumUtility(params E[] inputValue)
        {
            this.inputValue = inputValue;
        }

        public E FindMaximumNumber() 
        {
            Array.Sort(inputValue);
            int maximum = inputValue.Length - 1;
            return inputValue[maximum];
            
        }   
        public void ToprintMaximumNumber()
        {
            Console.WriteLine("The Maximum Number is {0}", inputValue[inputValue.Length-1]);
        }
    }

}