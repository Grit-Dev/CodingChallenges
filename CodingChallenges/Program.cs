
using CodingChallenges.Challenges.Phase_03_Practical_Challenges;

public class Program
{
    public static int CountValidPrices(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return 0;
        }

        string [] stringSplit = input.Split([','], StringSplitOptions.RemoveEmptyEntries);
        int counter = 0;

        foreach(string stringIndex in stringSplit)
        {
            if(int.TryParse(stringIndex.Trim(), out int result))
            {
                if( result > 0)
                {
                    counter++;
                }
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Valid Prices
        Console.WriteLine(CountValidPrices("10, 20, 0, -5, hello") == 2);
        Console.WriteLine(CountValidPrices("0, -1, abc") == 0);
        Console.WriteLine(CountValidPrices(" 5, 15 , test, 25 ")== 3);
        Console.WriteLine(CountValidPrices("")== 0);
        Console.WriteLine(CountValidPrices(null!)== 0);

        //JsonDataSanitizerRunner.Run();
    }

}
