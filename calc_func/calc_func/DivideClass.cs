
using System;

namespace calc_func
{
    public static class DivideClass
    {
        public static Result Divide(int n1, int n2)
        {
            if (n2 == 0)
            {
                return Result.Failure("You tried to divide by 0");
            }
            return Result.Success(n1/n2);
        }

        public static Result Divide(float n1, float n2)
        {
            if (n2 == 0)
            {
                return Result.Failure("You tried to divide by 0");
            }
            return Result.Success(n1 / n2);
        }

        public static Result Divide(long n1, long n2)
        {
            if (n2 == 0)
            {
                return Result.Failure("You tried to divide by 0");
            }
            return Result.Success(n1 / n2);
        }

        public static Result Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                return Result.Failure("You tried to divide by 0");
            }
            return Result.Success(n1 / n2);
        }
    }
}
