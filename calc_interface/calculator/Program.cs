using System;

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
            }
            while (chosenMethod == 0);
            
            while (chosenMethod < 0 || chosenMethod > 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Choose the number from the list! One more chance: ");
                CheckIfProperInput.ShowMenu();
                chosenMethod = int.Parse(Console.ReadLine());
            }

            Console.Write("Type in first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Type in second number: ");
            double num2 = double.Parse(Console.ReadLine());

            DoTheMath(chosenMethod, num1, num2);

            Console.ReadLine();
        }

        public static void DoTheMath(int choice, double numOne, double numTwo)
        {
            switch (choice)
            {
                case 1:
                {
                        AddClass action = new AddClass();
                        var result = action.DoTheAction(numOne, numTwo);
                        ShowTheResult(action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                case 2:
                {
                        SubtractClass action = new SubtractClass();
                        var result = action.DoTheAction(numOne, numTwo);
                        ShowTheResult(action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                case 3:
                {
                        MultiplyClass action = new MultiplyClass();
                        var result = action.DoTheAction(numOne, numTwo);
                        ShowTheResult(action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                case 4:
                    {
                        DivideClass action = new DivideClass();
                        var result = action.DoTheAction(numOne, numTwo);
                        ShowTheResult(action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There is no such a method! You were warned");
                        break;
                    }
            }
        }

        public static void ShowTheResult(string name, double num1, double num2, double result)
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
}
