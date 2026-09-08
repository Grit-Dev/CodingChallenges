
public class Program
{
    public static int CountNumbersBetweenTwoValues(int[] numbers, int min, int max)
    {
        if(numbers is null || numbers.Length == 0 || min > max)
        {
            return 0;
        }

        int counter = 0;

        foreach(int number in numbers)
        {
            if(number >= min && number <= max)
            {
                counter++;
            }
        }

        return counter;
    }
    public static void Main(string[] args)
    {
        // Count Numbers Between Two Values
        Console.WriteLine(CountNumbersBetweenTwoValues([1, 5, 10, 15, 20], 5, 15) == 3);
        Console.WriteLine(CountNumbersBetweenTwoValues([5, 10, 15], 6, 14) == 1);
        Console.WriteLine(CountNumbersBetweenTwoValues([-5, 0, 5], -5, 0) == 2);
        Console.WriteLine(CountNumbersBetweenTwoValues([1, 2, 3], 10, 5) == 0);
        Console.WriteLine(CountNumbersBetweenTwoValues(null!, 0, 10) == 0);
        Console.WriteLine(CountNumbersBetweenTwoValues([], 0, 10) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
