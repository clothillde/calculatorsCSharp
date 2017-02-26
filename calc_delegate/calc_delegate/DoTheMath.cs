using System;

class DoTheMath
{
    public static void Calculate(int choice, double numOne, double numTwo)
    {
        switch (choice)
        {
            case 1:
                {
                    SomeOperation addNumbers = Delegate.Add;
                    var result = addNumbers(numOne, numTwo);
                    ShowTheResults.Show("adding", numOne, numTwo, result);
                    break;
                }
            case 2:
                {
                    SomeOperation subtractNumbers = Delegate.Subtract;
                    var result = subtractNumbers(numOne, numTwo);
                    ShowTheResults.Show("subtracting", numOne, numTwo, result);
                    break;
                }
            case 3:
                {
                    SomeOperation multiplyNumbers = Delegate.Multiply;
                    var result = multiplyNumbers(numOne, numTwo);
                    ShowTheResults.Show("multiplying", numOne, numTwo, result);
                    break;
                }
            case 4:
                {
                    SomeOperation divideNumbers = Delegate.Divide;
                    var result = divideNumbers(numOne, numTwo);
                    ShowTheResults.Show("dividing", numOne, numTwo, result);
                    break;
                }
            default:
                {
                    Console.WriteLine("There is no such a method!");
                    break;
                }
        }
    }
}