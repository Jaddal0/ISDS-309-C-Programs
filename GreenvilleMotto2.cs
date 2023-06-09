using System;
using static System.Console;

class GreenvilleMotto2
{
    static void Main()
    {
        Write("Enter a Motto: ");
        string MottoInput = "* " + Console.ReadLine() + " *";
        int i = MottoInput.Length;
        int j = 0;
        int k = 0;

        while (i > j)
        {
            Write("*");
            j++;
        }

        WriteLine("\n{0}", MottoInput);

        for (k = 0; k < i; k++)
        {
            Write("*");
        }
        Write("\n");
    }
}
