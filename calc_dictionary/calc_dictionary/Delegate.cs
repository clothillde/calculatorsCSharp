using System;

namespace calc_dictionary
{
    class Delegate
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("You cannot divide by zero");
                return 0;
            }
            return x / y;
        }
    }
}

