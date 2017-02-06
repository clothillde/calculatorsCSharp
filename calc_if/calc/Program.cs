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
            Console.Write("Type in first integer number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Type in second integer number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the number of the method: ");
            Console.WriteLine("1. add");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. divide");

            int chosenMethod = int.Parse(Console.ReadLine());
            int result = 0;
            string method = " ";

            if (chosenMethod == 1)
            {
                result = num1 + num2;
                method = "adding";
                WriteResult(method, num1, num2, result);
            }
            else if (chosenMethod == 2)
            {
                result = num1 - num2;
                method = "subtracting";
                WriteResult(method, num1, num2, result);
            }
            else if (chosenMethod == 3)
            {
                result = num1 * num2;
                method = "multiplying";
                WriteResult(method, num1, num2, result);
            }
            else if (chosenMethod == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("You cannot divide by 0!!!");
                    Console.ReadLine();

                }
                else
                {
                    result = num1 / num2;
                    method = "dividing";
                    WriteResult(method, num1, num2, result);
                } 
            }
            else
            {
                Console.WriteLine("There is no such a method");
            }  
        }

        public static void WriteResult(string mMethod, int mNum1, int mNum2, int mResult)
        {
            Console.WriteLine("The result of {0} {1} and {2} is {3}", mMethod, mNum1, mNum2, mResult);
            Console.ReadLine();
        }
    }
}
