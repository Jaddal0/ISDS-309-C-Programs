using System;
using System.Diagnostics.Eventing.Reader;
using static System.Console;

class Admission
{
    static void Main()
    {

        string Decision = ("Y");

        while (Decision == "Y")
        {
            Write("Enter your GPA >> ");
            string GpaInput = Console.ReadLine();
            double Gpa = Convert.ToDouble(GpaInput);

            Write("Enter your test score >> ");
            string TestInput = Console.ReadLine();
            double Test = Convert.ToDouble(TestInput);

            if (Gpa >= 3.4 && Test >= 70)
                WriteLine("You are accepted");
            else
                if (Gpa < 3.4 && Test >= 80)
                    WriteLine("You are accepted");
            else
                WriteLine("Reject");

            
            Write("Would you like to enter again? (Y/N): ");
            Decision = Console.ReadLine();
        }
        
    }
}