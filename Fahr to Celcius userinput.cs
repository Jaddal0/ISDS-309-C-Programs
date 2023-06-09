using System;
using static System.Console;

//Jawad H Addal
//This program asks a user for a Fahrenheit degree and converts it to degrees Celcius

class FahrenheitToCelcius
{
    static void Main()
    {
        string userInput;
        Write("Enter Fahrenheit degrees >> ");
        userInput = ReadLine();
        double num1 = Convert.ToDouble(userInput);
        double degCel = (num1 - 32)*(5/9d);
        WriteLine("{0:d2} F is {1:d2} C", num1, degCel);
    }
}