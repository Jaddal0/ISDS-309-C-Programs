using System;
using static System.Console;

class ParallelArray
{
    static void Main()
    {
        int[] studentID = { 1012, 1033, 1156, 1569, 1920 };
        string[] firstName = { "Bones", "Welma", "Frank", "Hanes", "Jack" };
        string[] lastName = { "Smith", "Seger", "Mathers", "Solo", "Bush" };
        string[] status = { "freshman", "sophomore", "senior", "junior", "freshman" };

        bool isValidID = false;
        Write("Please enter a Student ID >> ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        int i;

        for (i = 0; i < studentID.Length; i++)
        {
            if (userInput == studentID[i])
            {
                isValidID = true;
                break;
            }
        }
        
        if (isValidID == true)
        {
            WriteLine("The students first name is {0}", firstName[i]);
            WriteLine("The students last name is {0}", lastName[i]);
            WriteLine("The student is a {0}", status[i]);
        }
        else
            WriteLine("Sorry - student not found");
    }
}
