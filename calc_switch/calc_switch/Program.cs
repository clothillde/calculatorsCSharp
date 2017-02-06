using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****CALCULATOR****");

            ShowMenu();

            string chosenMethod = Console.ReadLine();

            if (chosenMethod != "add" && chosenMethod != "subtract" && chosenMethod != "multiply" &&
                chosenMethod != "divide")
            {
                Console.WriteLine();
                Console.WriteLine("Choose the action from the list!");
                Console.WriteLine();
                ShowMenu();
            }

            Console.Write("Type in first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Type in second number: ");
            double num2 = double.Parse(Console.ReadLine());

            DoTheMath(chosenMethod, num1, num2);
          
        }

        public static void ShowMenu()
        {
            Console.WriteLine("Type in what do you want to do: ");
            Console.WriteLine("add");
            Console.WriteLine("subtract");
            Console.WriteLine("multiply");
            Console.WriteLine("divide");
        }

        public static void DoTheMath(string choice, double numOne, double numTwo)
        {
            double result;
            string method;

            switch (choice)
            {
                case "add":
                    {
                        result = numOne + numTwo;
                        method = "adding";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                case "subtract":
                    {
                        result = numOne - numTwo;
                        method = "subtracting";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                case "multiply":
                    {
                        result = numOne * numTwo;
                        method = "multiplying";
                        WriteResult(method, numOne, numTwo, result);
                        break;
                    }
                case "divide":
                    {
                        if (numTwo == 0)
                        {
                            Console.WriteLine("You cannot divide by 0!!!");
                            Console.ReadLine();

                        }
                        else
                        {
                            result = numOne / numTwo;
                            method = "dividing";
                            WriteResult(method, numOne, numTwo, result);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("There is no such a method! You were warned");
                        Console.ReadLine();
                        break;
                    }

            }
        }

        public static void WriteResult(string mMethod, double mNum1, double mNum2, double mResult)
        {
            Console.WriteLine("The result of {0} {1} and {2} is {3}", mMethod, mNum1, mNum2, mResult);
            Console.ReadLine();
        }
    }
}
