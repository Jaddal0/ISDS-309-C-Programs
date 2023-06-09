using System;
using static System.Console;

class Asterisk
{
    static void Main()
    {

        for (int i = 10; i > 0; i--)
        {

            for (int j = 0; j < i; j++)
            {
                Write("*");
            }

            Write("\n");

        }
    }
}
