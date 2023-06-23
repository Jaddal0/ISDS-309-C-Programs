using System;
using static System.Console;
using System.Collections.Generic;

class Parallel_Lists
{
    static void Main()
    {
        List<int>    studentID =    new List<int> { 1012, 1033, 1156, 1569, 1920 };
        List<string> firstName =    new List<string> { "Bones", "Welma", "Frank", "Hanes", "Jack" };
        List<string> lastName =     new List<string> { "Smith", "Seger", "Mathers", "Solo", "Bush" };
        List<string> status =       new List<string> { "freshman", "sophomore", "senior", "junior", "freshman" };

        Write("Please enter a Student ID or 0 to exit >> ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        while (userInput != 0)
        {
            int x = studentID.IndexOf(userInput);
            if (x >= 0)
            {
                for (int i = 0; i < studentID.Count; i++)
                {
                    if (userInput == studentID[i])
                    {
                        WriteLine("The student's first name is {0}", firstName[i]);
                        WriteLine("The student's last name is {0}", lastName[i]);
                        WriteLine("The student's status is {0}", status[i]);
                        break;
                    }
                }
            }
            else
            {
                WriteLine("Sorry, the student is not found");
                studentID.Add(userInput);

                Write("Please enter the student's first name >> ");
                firstName.Add(ReadLine());

                Write("Please enter the student's last name >> ");
                lastName.Add(ReadLine());

                Write("Please enter the student's status >> ");
                status.Add(ReadLine());
            }

            Write("Please enter a Student ID or 0 to exit >> ");
            userInput = Convert.ToInt32(ReadLine());
        }
    }
}