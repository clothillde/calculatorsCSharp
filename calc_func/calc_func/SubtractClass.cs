
namespace calc_func
{
    public static class SubtractClass
    {
        public static Result Subtract(int n1, int n2)
        {
            return Result.Success(n1 - n2);
        }

        public static Result Subtract(float n1, float n2)
        {
            return Result.Success(n1 - n2);
        }

        public static Result Subtract(long n1, long n2)
        {
            return Result.Success(n1 - n2);
        }

        public static Result Subtract(double n1, double n2)
        {
            return Result.Success(n1 - n2);
        }
    }
}
