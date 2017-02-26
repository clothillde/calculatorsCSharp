using System;

public delegate double SomeOperation(double a, double b);

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***CALCULATOR***");

            CheckIfProperInput.ShowMenu();

            int chosenMethod;

            do
            {
                chosenMethod = CheckIfProperInput.CheckIfItIsNumber();
            } while (chosenMethod == 0);

            while (chosenMethod < 0 || chosenMethod > 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Choose the number from the list! One more chance: ");
                CheckIfProperInput.ShowMenu();
                chosenMethod = int.Parse(Console.ReadLine());
            }

            Console.Write("Type in first number: ");
            var num1 = double.Parse(Console.ReadLine());

            Console.Write("Type in second number: ");
            var num2 = double.Parse(Console.ReadLine());

            DoTheMath.Calculate(chosenMethod, num1, num2);
            Console.ReadLine();
        }
    }
}
