using System;
using static System.Console;

/*
Write a program to display integers from 1 to 20, and then display their sum
-using a while loop
-using a for loop
*/

class idk
{
    static void Main()
    {
        int num = 1;
        while (num <= 20)
        {
            Write("{0} ", num);
            num++;
        }

        int sum = 0;
        for (int i = 1; i <= 20; i++)
        {
            sum = sum + i;
        }
        WriteLine("\nSum is {0}", sum);
    }
}