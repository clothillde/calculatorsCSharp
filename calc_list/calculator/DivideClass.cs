using System;

namespace calculator
{
    public class DivideClass : IAction
    {
        public double DoTheAction(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("You cannot divide by zero");
                return 0;
            }
            return a / b;
        }
        public string NameOfTheAction => "dividing";
    }
}
