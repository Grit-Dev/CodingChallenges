using CodingChallenges.Challenges.Phase_02_OOP;

public class Program
{   
    public static int CountPeaks(int[] numbers)
    {
        if( numbers == null || numbers.Length < 3)
        {
            return 0;
        }

        int previousPosition = numbers[0];
        int counter = 0;

        for(int outterIndex = 2; outterIndex <= numbers.Length -1; outterIndex++)
        {
            int currentPosition = numbers[outterIndex -1];
            int futurePosition = numbers[outterIndex];

            if(currentPosition > previousPosition && currentPosition > futurePosition)
            {
                counter++;
            }

            previousPosition = currentPosition;


        }

        return counter;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(CountPeaks([1, 3, 2, 4, 1]));
        Console.WriteLine(CountPeaks([1, 3, 2]));
        Console.WriteLine(CountPeaks([5, 4, 3, 2, 1]));
        Console.WriteLine(CountPeaks([1, 2, 3, 4]));
        Console.WriteLine(CountPeaks(null!));
        Console.WriteLine(CountPeaks([1, 2, 3, 4]));
        Console.WriteLine(CountPeaks([1,2]));

        // CardShopTransactionReportsChallenges.Run();
        // CardShopTransactionHistoryChallenges.TransactionHistoryChallenges_Run_23_07_2026();

    }
}
