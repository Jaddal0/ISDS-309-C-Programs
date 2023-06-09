using System;
using static System.Console;

class EmployeeBonus
{
    static void Main()
    {
        int Bonus = 0;
        string Decision;
        Write("Are you an hourly employee? Y/N: ");
        Decision = ReadLine();

        if (Decision == "Y")
        {
            string WorkHours;
            Write("Enter work hours per week: ");
            WorkHours = ReadLine();
            int WorkHoursInput = Convert.ToInt32(WorkHours);

            if (WorkHoursInput > 40)
            {
                Bonus += 500;
                Write("You work more than 40 hours per week. Your bonus is: {0:C2}\n", Bonus);
            }
            else
            {
                Bonus += 100;
                Write("You work less than 40 hours per week. Your bonus is {0:C2}\n", Bonus);
            }
        }

        if (Decision == "N")
        {
            string WorkYears;
            Write("How many years are you employed? ");
            WorkYears = ReadLine();
            int WorkYearsInput = Convert.ToInt32(WorkYears);

            if (WorkYearsInput > 10)
                {
                    Bonus += 300;
                    Write("You are a full time employee and your bonus is {0:C2}\n", Bonus);
                }
                else
                    {
                        Bonus += 200;
                        Write("You are a full time employee and your bonus is {0:C2}\n", Bonus);
                    }
        }

    }
}