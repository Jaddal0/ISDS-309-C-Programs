using System;
using static System.Console;

//Jawad H Addal
//This program converts degrees Fahrenheit to degrees Celcius

class FahrenheitToCelcius
{
    static void Main()
    {
        int degFahr = 28;
        float degCelc = (degFahr - 32)*(5/9f);
        WriteLine("{0} degrees Fahrenheit is {1:f2} degrees Celcius", degFahr, degCelc);
    }
}