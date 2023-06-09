using System;
using static System.Console;

class Exe5_1
{
    static void Main()
    {
        Write("Please input a string >> ");
        string Word = Console.ReadLine();

        while (Word.Length < 5)
        {
            Write("Please input a string of at least five characters >> ");
            Word = Console.ReadLine();
        }
        Write("The last five characters of the string is \"{0}\" \n", Word.Substring(Word.Length - 5));
    }
}