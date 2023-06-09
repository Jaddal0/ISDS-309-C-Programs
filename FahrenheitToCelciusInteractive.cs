using System;
using static System.Console;

//This program converts degrees Fahrenheit to degrees Celcius
class FahrenheitToCelcius
{
    static void Main()
    {
        Write("Enter Fahrenheit Degrees >> ");
        string userInputFahr = ReadLine();
        double degFahr = Convert.ToDouble(userInputFahr);
        double degCelc = (degFahr - 32) * (5 / 9f);
        WriteLine("{0} F is {1:f1} C", degFahr, degCelc);
    }
}