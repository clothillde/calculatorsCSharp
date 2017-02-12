
namespace calculator
{
    public class SubtractClass : IAction
    {
        public double DoTheAction(double a, double b)
        {
            return a - b;
        }
        public string NameOfTheAction => "subtracting";
    }
}
