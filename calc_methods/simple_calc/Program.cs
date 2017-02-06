using System;

namespace simple_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************");
            Console.WriteLine("Simple calc");
            Console.WriteLine("********************");

            Console.WriteLine("Type in two numbers:");
            Console.Write("First number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose the number of the method: ");
            Console.WriteLine("1. add");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. divide");

            int chosenMethod = int.Parse(Console.ReadLine());

            Actions doSth = new Actions();
            double result = 0;

            switch (chosenMethod)
            {
                case 1:
                    Console.WriteLine("Method: add");
                    result = doSth.addMethod(numberOne, numberTwo);
                    break;
                case 2:
                    Console.WriteLine("Method: subtract");
                    result = doSth.subtractMethod(numberOne, numberTwo);
                    break;
                case 3:
                    Console.WriteLine("Method: multiply");
                    result = doSth.multiplyMethod(numberOne, numberTwo);
                    break;
                case 4:
                    Console.WriteLine("Method: divide");
                    result = doSth.divideMethod(numberOne, numberTwo);
                    break;
                default:
                    Console.WriteLine("there is no such method");
                    break;
            }
            if (numberTwo != 0)
            {
                Console.WriteLine("result of the action is: {0}", result);
            }
            
            Console.ReadLine();
        }
       


    }


       
    

}
