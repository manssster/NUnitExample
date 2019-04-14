using System;

namespace NUnitCalcTest.CalcLib
{
    public class Calculator
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Division(double numerator, double denominator)
        {
            return numerator / denominator;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
