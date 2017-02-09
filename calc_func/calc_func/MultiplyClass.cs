
namespace calc_func
{
    public static class MultiplyClass
    {
        public static Result Multiply(int n1, int n2)
        {
            return Result.Success(n1 * n2);
        }

        public static Result Multiply(float n1, float n2)
        {
            return Result.Success(n1 * n2);
        }

        public static Result Multiply(long n1, long n2)
        {
            return Result.Success(n1 * n2);
        }

        public static Result Multiply(double n1, double n2)
        {
            return Result.Success(n1 * n2);
        }
    }
}
