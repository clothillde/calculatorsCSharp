
namespace calculator
{
    public class MultiplyClass : IAction
    {
        public double DoTheAction(double a, double b)
        {
            return a * b;
        }

        public string NameOfTheAction => "multiplying";
    }
}
