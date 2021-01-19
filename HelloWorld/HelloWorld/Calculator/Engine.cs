using System;

namespace HelloWorld.Calculator
{
    public class Engine
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double y)
        {
            return a * y;
        }

        public double Divide(double a, double b)
        {
            if (b == 0) return Math.PI;
            return a / b;
        }

    }
}
