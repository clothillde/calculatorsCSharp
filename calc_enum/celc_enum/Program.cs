using System;

namespace celc_enum
{

    enum Actions { Add, Subtract, Multiply, Divide}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***CALCULATOR***");

            ShowMenu();

            int chosenMethod = int.Parse(Console.ReadLine());

            while (chosenMethod < 0 || chosenMethod > 4)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Choose the number from the list! One more chance: ");
                ShowMenu();
                chosenMethod = int.Parse(Console.ReadLine());
            }


            Console.Write("Type in first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Type in second number: ");
            double num2 = double.Parse(Console.ReadLine());

            DoTheMath(chosenMethod, num1, num2);

            Console.ReadLine();
        }

        public static void ShowMenu()
        {
            Console.WriteLine("What do you want to do: ");
            string[] actionsString = Enum.GetNames(typeof(Actions));
            for (int i = 1; i <= actionsString.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, actionsString[i-1]);
            }
        
        }

        public static void DoTheMath(int choice, double numOne, double numTwo)
        {
            double result;

            switch (choice)
            {
                case 1:
                    {
                        result = AddClass.Add(numOne, numTwo);
                        Actions resultAction = (Actions)0;
                        WriteResult(resultAction, numOne, numTwo, result);
                        break;
                    }
                case 2:
                    {
                        result = SubtractClass.Subtract(numOne, numTwo);
                        Actions resultAction = (Actions)1;
                        WriteResult(resultAction, numOne, numTwo, result);
                        break;
                    }
                case 3:
                    {
                        result = MultiplyClass.Multiply(numOne, numTwo);
                        Actions resultAction = (Actions)2;
                        WriteResult(resultAction, numOne, numTwo, result);
                        break;
                    }
                case 4:
                    {
                        if (numTwo == 0)
                        {
                            Console.WriteLine("You cannot divide by 0!!!");
                        }
                        else
                        {
                            result = DivideClass.Divide(numOne, numTwo);
                            Actions resultAction = (Actions)3;
                            WriteResult(resultAction, numOne, numTwo, result);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There is no such a method! You were warned");
                        break;
                    }

            }
        }

        public static void WriteResult(Actions resultActions, double mNum1, double mNum2, double mResult)
        {
            Console.WriteLine("The result of {0} action with {1} and {2} is {3}", resultActions, mNum1, mNum2, mResult);
        }
    }
}
