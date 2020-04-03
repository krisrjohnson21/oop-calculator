using System;

namespace OOPCalculator
{
    class Calculator
    {
        public static double DoOperation(double numOne, double numTwo, string op)
        {
            double result = double.NaN;
            switch(op)
            {
                case "a":
                    result = numOne + numTwo;
                    break;
                case "s":
                    result = numOne - numTwo;
                    break;
                case "m":
                    result = numOne * numTwo;
                    break;
                case "d":
                    result = numOne / numTwo;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
