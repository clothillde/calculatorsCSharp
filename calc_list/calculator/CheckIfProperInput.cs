using System;

namespace calculator
{
    class CheckIfProperInput
    {
        public static void ShowMenu()
        {
            Console.WriteLine("What do you want to do: ");
            Console.WriteLine("1. add");
            Console.WriteLine("2. subtract");
            Console.WriteLine("3. multiply");
            Console.WriteLine("4. divide");
        }

        public static int CheckIfItIsNumber()
        {
            var result = Console.ReadLine();
            int resultChoice;

            if (IsNumeric(result))
            {
                resultChoice = Int32.Parse(result);
            }
            else
            {
                Console.WriteLine("You should type in a number!");
                return 0;
            }

            return resultChoice;
        }

        public static bool IsNumeric(string input)
        {
            int test;
            return Int32.TryParse(input, out test);
        }
    }
}
