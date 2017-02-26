using System;
using System.Collections.Generic;
using Delegate = calc_dictionary.Delegate;

class DoTheMath
{
    public static void Calculate(int choice, double numOne, double numTwo)
    {

        IDictionary<int, string> allActionsDictionary = new Dictionary<int, string>(){
                                                                                        {1,"adding"},
                                                                                        {2,"subtracting"},
                                                                                        {3,"multiplying"},
                                                                                        {4,"dividing"}
                                                                                     };

        switch (choice)
        {
            case 1:
                {
                    SomeOperation addNumbers = Delegate.Add;
                    var result = addNumbers(numOne, numTwo);
                    ShowTheResults.Show(allActionsDictionary[1], numOne, numTwo, result);
                    break;
                }
            case 2:
                {
                    SomeOperation subtractNumbers = Delegate.Subtract;
                    var result = subtractNumbers(numOne, numTwo);
                    ShowTheResults.Show(allActionsDictionary[2], numOne, numTwo, result);
                    break;
                }
            case 3:
                {
                    SomeOperation multiplyNumbers = Delegate.Multiply;
                    var result = multiplyNumbers(numOne, numTwo);
                    ShowTheResults.Show(allActionsDictionary[3], numOne, numTwo, result);
                    break;
                }
            case 4:
                {
                    SomeOperation divideNumbers = Delegate.Divide;
                    var result = divideNumbers(numOne, numTwo);
                    ShowTheResults.Show(allActionsDictionary[4], numOne, numTwo, result);
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