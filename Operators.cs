using System;

namespace Operators
{
    void main()
    {
        int myNum = 50;
        double doubleNum = -29.99;
        char letter = 'b';
        string word = "Hello World";
        bool headsUp = true;

        Console.WriteLine("Integer value is: " + myNum);
        Console.WriteLine("Double value is: " + doubleNum);
        Console.WriteLine("Char value is: " + letter);
        Console.WriteLine("String value is: " + word);
        Console.WriteLine("Bool value is: " + headsUp);

        myNum = 25 - 3;
        doubleNum = doubleNum / 6.29;
        letter = 'z';
        word = "Goodbye World";
        headsUp = false;

        if (doubleNum < -5)
            doubleNum = -10;

        Console.WriteLine("Integer value is: " + myNum);
        Console.WriteLine("Double value is: " + doubleNum);
        Console.WriteLine("Char value is: " + letter);
        Console.WriteLine("String value is: " + word);
        Console.WriteLine("Bool value is: " + headsUp);
    }
}