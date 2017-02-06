using System;

namespace simple_calc
{
    class Actions
    {
        public double addMethod(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subtractMethod(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiplyMethod(double num1, double num2)
        {
            return num1 * num2;
        }

        public double divideMethod(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Shame on you, do not divide by zero!!!");
                return 0;
            }
            else
            {
                return num1 / num2;
            }

        }
    }
}
