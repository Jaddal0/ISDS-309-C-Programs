//Exe 6-2 AverageScoreArray
        int[] avgScore = new int[5];
        for (int k = 0; k < avgScore.Length; k++)
        {
            Console.WriteLine("Enter an integer test score: ");
            avgScore[k] = Convert.ToInt32(ReadLine());
        }
        WriteLine("The integers entered are:");