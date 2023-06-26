using System;
using static System.Console;

class Exe_7_1
{
    static void Main()
    {
        Write("Enter the unit price in $ >> ");
        double price = Convert.ToDouble(ReadLine());
        Write("Enter the quantity of purchase >> ");
        int quantity = Convert.ToInt32(ReadLine());
        CalSales(double price, int quantity);
    }
    private static void CalSales(double price, int quantity)
    {
        double product = price * quantity;
        Console.WriteLine("The total purchase is {0:C}", product);
    }
}