using System;
using static System.Console;

class AverageScoreArray
{
    static void Main()
    {
        int[] scoreArray = new int[5];
        double sum = 0;

        for (int i = 0; i < scoreArray.Length; i++)
        {
            Write("Enter an integer test score >> ");
            scoreArray[i] = Convert.ToInt32(ReadLine());
        }
        Console.WriteLine("\nThe integers entered are: ");

        for (int i = 0;i < scoreArray.Length; i++)
        {
            Console.WriteLine(scoreArray[i]);
            sum += scoreArray[i];
        }

        double avg = sum / scoreArray.Length;
        Console.WriteLine("\nThe average score is {0:0.00}\n", avg);
    }
}
