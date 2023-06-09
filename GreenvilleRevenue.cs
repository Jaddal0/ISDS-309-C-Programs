using System;
using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        Write("Enter number of contestants from last year >> ");
        string LastYearInput = ReadLine();
        Write("Enter number of contestants from this year >> ");
        string ThisYearInput = ReadLine();
        double ThisYear = Convert.ToDouble(ThisYearInput);
        double ExpRev = ThisYear * 25;
        WriteLine("Contestants from last year is {0}", LastYearInput);
        WriteLine("Contestants from this year is {0}", ThisYearInput);
        WriteLine("Revenue expected this year is {0:C2}", ExpRev);
    }
}