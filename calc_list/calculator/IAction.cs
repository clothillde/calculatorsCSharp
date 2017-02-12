namespace calculator
{
    interface IAction
    {
        double DoTheAction(double a, double b);

        string NameOfTheAction { get; }
    }
}