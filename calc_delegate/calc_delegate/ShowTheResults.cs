using System;

class ShowTheResults
{
    public static void Show(string name, double num1, double num2, double result)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Failure");
        }
        else
        {
            Console.WriteLine("The result of {0} between: {1} and {2} is {3}", name, num1, num2, result);
        }
    }
}

