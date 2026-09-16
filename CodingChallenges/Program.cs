public class Program
{
    public static int[] GetTopTwoEvenNumbersWithLinq(int[] numbers) => 
    numbers is null || numbers.Length == 0 ? [] :
    numbers.Where(n => n % 2 == 0).OrderByDescending(n => n).Take(2).ToArray();

    public static void Main(string[] args)
    {
        // Get Top Two Even Numbers
        Console.WriteLine(GetTopTwoEvenNumbersWithLinq([1, 8, 4, 10, 3]).SequenceEqual([10, 8]));
        Console.WriteLine(GetTopTwoEvenNumbersWithLinq([2]).SequenceEqual([2]));
        Console.WriteLine(GetTopTwoEvenNumbersWithLinq([7, 9]).Length == 0);
        Console.WriteLine(GetTopTwoEvenNumbersWithLinq(null!).Length == 0);
        Console.WriteLine(GetTopTwoEvenNumbersWithLinq([]).Length == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
