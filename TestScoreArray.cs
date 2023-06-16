using System;

class TestScoreArray
{
    static void Main()
    {
        int [] testScores = {85, 98, 100, 73, 67, 82, 92, 87};
        double sum = 0;
        double avg = 0;
        Console.Write("The eight numbers are ");
        
        for (int i = 0; i < 8; i++)
        {
            sum += testScores[i];
        }
        
        for (int j = 0; j < 8; j++)
        {
            Console.Write(testScores[j] + ", ");
        }
        avg = sum / 8;
        Console.WriteLine ("\nThe average is {0:F}", avg);
    }
}