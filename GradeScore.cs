using System;
using static System.Console;

class GradeScore
{
        static void Main()
    { 
        Write("Please enter your course score >> ");
        string gradeInput = Console.ReadLine();
        double grade = Convert.ToDouble(gradeInput);

        if(grade >= 90 && grade <= 100 || grade > 100)
        {
            WriteLine("Your course grade is: A");
        }

        if (grade >= 80 && grade <= 89.99)
        {
            WriteLine("Your course grade is: B");
        }

        if (grade >= 70 && grade <= 79.99)
        {
            WriteLine("Your course grade is: C");
        }

        if (grade >= 60 && grade <= 69.99)
        {
            WriteLine("Your course grade is: D");
        }

        if (grade < 60)
        {
            WriteLine("Your course grade is: F");
        }
    }
}
