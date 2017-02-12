
namespace calculator
{
    public class AddClass : IAction
    {
        public double DoTheAction(double a, double b)
        {
            return a + b;
        }

        public string NameOfTheAction => "adding";
    }
}
