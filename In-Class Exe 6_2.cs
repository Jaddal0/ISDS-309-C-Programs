using System;
using static System.Console;

class idk
{
    static void Main()
    {
        int[] myIntArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool found = false;
        Write("Enter an integer: ");
        int inputInt = Convert.ToInt32(ReadLine());
        int i;

        for (i = 0; i <= myIntArray.Length-1; i++)
        {
            if (myIntArray[i] == inputInt)
            {
                found = true;
                break;
            }
        }
        
        if (found)
            WriteLine("Integer is found at index {0}", i);
        else
            WriteLine("Integer not found");
    }
}