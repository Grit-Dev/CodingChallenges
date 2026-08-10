public class Program
{
    public static int CountValidScores_Rev(string input)
    {
        if(string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string [] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach(var str in splitString)
        {
            if(int.TryParse(str.Trim(), out int result))
            {
                if(result >= 0 && result <= 100)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Valid Scores
        Console.WriteLine(CountValidScores_Rev("10, 50, 101, -1, hello, 80") == 3);
        Console.WriteLine(CountValidScores_Rev("0, 100, 55") == 3);
        Console.WriteLine(CountValidScores_Rev("abc, -5, 200") == 0);
        Console.WriteLine(CountValidScores_Rev("") == 0);
        Console.WriteLine(CountValidScores_Rev(" ") == 0);

        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
