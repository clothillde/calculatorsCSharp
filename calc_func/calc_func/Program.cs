using System;

namespace calc_func
{
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
            Console.WriteLine("1. add");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. divide");
        }
        
        public static void DoTheMath(int choice, double numOne, double numTwo)
        {
            Result result;
            string method;

            switch (choice)
            {
                case 1:
                {
                        result = AddClass.Add(numOne, numTwo);
                        method = "adding";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                case 2:
                {       
                        result = SubtractClass.Subtract(numOne, numTwo);
                        method = "subtracting";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                case 3:
                {
                        result = MultiplyClass.Multiply(numOne, numTwo);
                        method = "multiplying";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                case 4:
                    {
                        
                        result = DivideClass.Divide(numOne, numTwo);
                        method = "dividing";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There is no such a method! You were warned");
                        break;
                    }

            }
        }

        public static void WriteResult(string method, double mNum1, double mNum2, Result mResult)
        {

            if (mResult.IsSuccess)
            {
                Console.WriteLine("The result of {0} {1} and {2} is {3}", method, mNum1, mNum2, mResult);
            }
            else
            {
                Console.WriteLine("The result of {0} ended up with a failure: {1}", method, mResult);
            }
            
        }
    }
}
