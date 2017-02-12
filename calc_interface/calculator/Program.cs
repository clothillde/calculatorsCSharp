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
                        AddClass dzialanie = new AddClass();
                        var wynik = dzialanie.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", dzialanie.NameOfTheAction, numOne, numTwo, wynik);
                        break;
                    }
                case 2:
                {
                        SubtractClass dzialanie = new SubtractClass();
                        var wynik = dzialanie.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", dzialanie.NameOfTheAction, numOne, numTwo, wynik);
                        break;
                    }
                case 3:
                {
                        MultiplyClass dzialanie = new MultiplyClass();
                        var wynik = dzialanie.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", dzialanie.NameOfTheAction, numOne, numTwo, wynik);
                        break;
                    }
                case 4:
                    {
                        DivideClass dzialanie = new DivideClass();
                        var wynik = dzialanie.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", dzialanie.NameOfTheAction, numOne, numTwo, wynik);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There is no such a method! You were warned");
                        break;
                    }
            }
        }

    }
}
