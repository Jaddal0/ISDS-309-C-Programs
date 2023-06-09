using System;
using static System.Console;

//This program converts degrees Fahrenheit to degrees Celcius
class FahrenheitToCelcius
{
    static void Main()
    {
        int degFahr = 180;
        float degCelc = (degFahr - 32)*(5/9f);
        WriteLine(degFahr + " degrees Fahrenheit is " +  $"{degCelc:f2}" + " degrees Celcius");
        WriteLine("{0} degrees Fahrenheit is {1:f2} degrees Celcius", degFahr, degCelc);
    }
}