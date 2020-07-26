using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class MaximumUtility<E> where E : IComparable
    {
        E firstNumber;
        E secondNumber;
        E thirdNumber;

        public MaximumUtility(E firstNumber, E secondNumber, E thirdNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
            this.thirdNumber = thirdNumber;
        }

        public E FindMaximumNumber()
        {
            E maximum = firstNumber;
            if (maximum.CompareTo(secondNumber) < 0)
                maximum = secondNumber;
            if (maximum.CompareTo(thirdNumber) < 0)
                maximum = thirdNumber;
            return maximum;
        }
    }
}