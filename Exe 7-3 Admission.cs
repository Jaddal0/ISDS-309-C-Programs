using System;
using static System.Console;

class Admission
{
    static void Main()
    {
        Write("Enter your GPA >> ");
        double gpa = Convert.ToDouble(ReadLine());

        Write("Enter your test score >> ");
        double score = Convert.ToDouble(ReadLine());
        
        string decision = "";
        
        string result = MakeDecision(gpa, score, decision);
        Console.WriteLine(result);


    }
    private static string MakeDecision(double gpa, double score, string decision)
    {
        if (gpa >= 3.4 && score >= 60)
        {
            decision = "You are accepted";
            return decision;
        }
            else
                if (gpa < 3.4 && score >= 70)
                {
                    decision = "You are accepted";
                    return decision;
                }
        else
        {
            decision = "You are rejected";
            return decision;
        }
        
    }
}