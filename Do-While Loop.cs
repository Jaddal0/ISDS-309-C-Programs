using System;
using static System.Console;
class LoopingBankBal
{
    static void Main()
    {
        double bankBal = 1000;
        const double INT_RATE = 0.04;
        char response;

        do
        {
            Write("Bank balance is {0:C2}", bankBal);
            bankBal = bankBal + bankBal * INT_RATE;
            Write("\nDo you want to see next year’s balance? Y or N ...");
            response = Convert.ToChar(ReadLine());
        } while (response == 'Y' || response == 'y');
        
        WriteLine("Have a nice day!");

    }
}
