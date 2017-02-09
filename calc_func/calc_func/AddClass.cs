
namespace calc_func
{
    public static class AddClass
    {
        public static Result Add(int n1, int n2)
        {
            return Result.Success(n1 + n2);
        }
        public static Result Add(float n1, float n2)
        {
            return Result.Success(n1 + n2);
        }
        public static Result Add(long n1, long n2)
        {
            return Result.Success(n1 + n2);
        }

        public static Result Add(double n1, double n2)
        {
            return Result.Success(n1 + n2);
        }
    }
}
