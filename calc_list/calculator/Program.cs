﻿using System;
using System.Collections.Generic;
using System.Linq;

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
            var allActions = new List<IAction>
            {
                new AddClass(),
                new SubtractClass(),
                new MultiplyClass(),
                new DivideClass()
            };

            switch (choice)
            {
                case 1:
                {
                        var action = allActions.Single(d => d.NameOfTheAction == "adding");
                        var result = action.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                case 2:
                {
                        var action = allActions.Single(d => d.NameOfTheAction == "subtracting");
                        var result = action.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                case 3:
                {
                        var action = allActions.Single(d => d.NameOfTheAction == "multiplying");
                        var result = action.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", action.NameOfTheAction, numOne, numTwo, result);
                        break;
                    }
                case 4:
                    {
                        var action = allActions.Single(d => d.NameOfTheAction == "dividing");
                        var result = action.DoTheAction(numOne, numTwo);
                        Console.WriteLine("The result of {0} between: {1} and {2} is {3}", action.NameOfTheAction, numOne, numTwo, result);
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
