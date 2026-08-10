public class Program
{
    public static int CountValidScores_Rev(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int counter = 0;
        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (var str in splitString)
        {
            if (int.TryParse(str.Trim(), out int result))
            {
                if (result >= 0 && result <= 100)
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    public static string MaskReferenceExceptLastFour_Rev(string reference)
    {
        if (string.IsNullOrWhiteSpace(reference))
        {
            return "";
        }

        if(reference.Length <= 4)
        {
            return reference;
        }

        int characterLeftOver = reference.Length - 4;

        string asterisks = new('*', characterLeftOver);

        string lastFourCharacters = reference.Substring(characterLeftOver);

        return asterisks + lastFourCharacters;
    }
    public static void Main(string[] args)
    {

        // Mask Reference Except Last Four
        Console.WriteLine(MaskReferenceExceptLastFour_Rev("ABC1234567") == "******4567");
        Console.WriteLine(MaskReferenceExceptLastFour_Rev("1234") == "1234");
        Console.WriteLine(MaskReferenceExceptLastFour_Rev("ABC") == "ABC");
        Console.WriteLine(MaskReferenceExceptLastFour_Rev("") == "");
        Console.WriteLine(MaskReferenceExceptLastFour_Rev(" ") == "");

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
