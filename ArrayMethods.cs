using System;
using static System.Console;

class ArrayMethods
{
    static void Main()
    {
        //IndexOf() Method. Is Sequential, meaning is starts checking from left to right
        int[] myIntArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Write("Enter an integer: ");
        int inputInt = Convert.ToInt32(ReadLine());
        int i = Array.IndexOf(myIntArray, inputInt);

        if (i>=0)
            WriteLine("Integer is found at index {0}", i);
        else
            WriteLine("Integer not found");
        //End of IndexOf() Method

        //BinarySearch() Method. Starts from the middle, array MUST be sorted in ASCENDING ORDER.
        int[] idNumbers = { 122, 167, 204, 219, 345 };
        Write("Enter an Employee ID >> ");
        int entryId = Convert.ToInt32(ReadLine());
        int x = Array.BinarySearch(idNumbers, entryId);
        if (x < 0)
            WriteLine("ID {0} not found", entryId);
        else
            WriteLine("ID {0} found at position {1} ", entryId, x);
        //End of BinarySearch() Method

    }
}