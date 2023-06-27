using System;
using static System.Console;

class Exe_7_2
{
    static void Main()
    {
        Write("Enter the unit price in $ >> ");
        double price = Convert.ToDouble(ReadLine());
        
        Write("Enter the quantity of purchase >> ");
        int quantity = Convert.ToInt32(ReadLine());
        
        double product = CalSales(price, quantity);
        WriteLine("The total purchase is {0:C}", product);
    }
    private static double CalSales(double price, int quantity)
    {
        return (price * quantity);
    }
}