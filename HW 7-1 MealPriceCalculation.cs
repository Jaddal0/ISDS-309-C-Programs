using System;
using static System.Console;

class MealPriceCalculation
{
    static void Main()
    {
        double mealPrice = 0;
        double tip = 0;
        int tipPercent=0;
        double totalPrice = 0;

        CalPrice(mealPrice, tip, totalPrice);
        CalPrice(mealPrice, tipPercent, totalPrice);

    }
    private static void CalPrice(double mealPrice, double tip, double totalPrice)
    {
        Write("Please enter the meal price in dollar amount >> $");
        mealPrice = Convert.ToDouble(Console.ReadLine());

        Write("Please enter the tip in dollar amount >> $");
        tip = Convert.ToDouble(Console.ReadLine());

        totalPrice = mealPrice + tip;
        WriteLine("The meal price is {0:C}", totalPrice);
        WriteLine();
    }
    private static void CalPrice(double mealPrice, int tipPercent, double totalPrice)
    {
        Write("Please enter the meal price in dollar amount >> $");
        mealPrice = Convert.ToDouble(Console.ReadLine());

        Write("Please enter the tip percentage as a whole number (if tip is 15%, enter 15) >> %");
        tipPercent = Convert.ToInt32(Console.ReadLine());
        double tipPercent2 = Convert.ToDouble(tipPercent)/100;

        totalPrice = (mealPrice * tipPercent2) + mealPrice;
        WriteLine("The meal price is {0:C}", totalPrice);
        WriteLine();
    }
}
