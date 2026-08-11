using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{
    public static int? FindSecondHighestUniqueNumber(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? highestNumber = null;
        int? secondHighestNumber = null;

        foreach (int number in numbers)
        {
            if (highestNumber is null || number > highestNumber)
            {
                secondHighestNumber = highestNumber;
                highestNumber = number;
            }
            else if (number < highestNumber &&
                    (secondHighestNumber is null || number > secondHighestNumber))
            {
                secondHighestNumber = number;
            }
        }

        return secondHighestNumber;
    }

    public static void Main(string[] args)
    {
        //Find The Second Highest Unique Number
        Console.WriteLine(FindSecondHighestUniqueNumber([10, 20, 30]) == 20);
        Console.WriteLine(FindSecondHighestUniqueNumber([10, 30, 30, 20]) == 20);
        Console.WriteLine(FindSecondHighestUniqueNumber([5, 5, 5]) == null);
        Console.WriteLine(FindSecondHighestUniqueNumber([100, 50, 100, 25]) == 50);
        Console.WriteLine(FindSecondHighestUniqueNumber([-10, -5, -20]) == -10);
        Console.WriteLine(FindSecondHighestUniqueNumber(null!) == null);
        Console.WriteLine(FindSecondHighestUniqueNumber([]) == null);
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
