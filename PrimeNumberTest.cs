using System;
using static System.Console;
class PrimeNumberTest
{
    static void Main()
    {
        Write("Enter an integer that is greater than or equal to 2: ");
        int num;
        num = Convert.ToInt32(Console.ReadLine());
        int divisors = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                divisors++;
            }
        }

        if (divisors == 2)
        {
            Console.WriteLine("{0} is a Prime Number", num);
        }
        else
        {
            Console.WriteLine("{0} is a not a Prime Number", num);
        }
    }
}
