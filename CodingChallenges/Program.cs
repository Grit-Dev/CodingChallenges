
using System.Text;

public class Program
{
    public static int CountNumbersWithSameParityAsTheirIndex(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return 0;
        }

        int counter = 0;

        for (int outerIndex = 0; outerIndex <= numbers.Length - 1; outerIndex++)
        {
            if (numbers[outerIndex] % 2 == 0 && outerIndex % 2 == 0)
            {
                counter++;
            }
            else if (numbers[outerIndex] % 2 != 0 && outerIndex % 2 != 0)
            {
                counter++;
            }

        }

        return counter;
    }

    public static string MaskMiddleCharacters(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "";
        }

        if (input.Length <= 2)
        {
            return input;
        }

        return input[0] + new string('*', input.Length - 2) + input[input.Length - 1];
    }

    public static int? FindLargestJumpBetweenAdjacentNumbers(int[] numbers)
    {
        if (numbers is null || numbers.Length < 2)
        {
            return null;
        }

        int largestDistanceFound = Math.Abs(numbers[0] - numbers[1]);

        for (int outerIndex = 1; outerIndex <= numbers.Length - 1; outerIndex++)
        {

            int distanceCounter = Math.Abs(numbers[outerIndex - 1] - numbers[outerIndex]);

            if (distanceCounter > largestDistanceFound)
            {
                largestDistanceFound = distanceCounter;
            }
        }

        return largestDistanceFound;
    }

    public static int SumValidPaymentAmounts(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int total = 0;

        string[] splitString = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in splitString)
        {
            string strTrimmed = str.Trim();

            int index = strTrimmed.IndexOf(':');

            if (index == -1)
            {
                continue;
            }

            string name = strTrimmed.Substring(0, index).Trim();

            string amountText = strTrimmed.Substring(index + 1).Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(amountText))
            {
                continue;
            }

            if (int.TryParse(amountText, out int value) &&
                value >= 0)
            {
                total += value;
            }
        }

        return total;
    }

    public static Dictionary<string, int> GroupTemperaturesByBand(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return [];
        }

        string temperature = "";

        Dictionary<string, int> newDict = [];

        foreach (int number in numbers)
        {
            if (number < 10)
            {
                temperature = "cold";
            }
            else if (number >= 10 && number <= 20)
            {
                temperature = "mild";
            }
            else
            {
                temperature = "hot";
            }

            if (newDict.TryGetValue(temperature, out int value))
            {
                newDict[temperature] = value + 1;
            }
            else
            {
                newDict[temperature] = 1;
            }
        }

        return newDict;
    }
    public static void Main(string[] args)
    {
        // Group Temperatures By Band
        Dictionary<string, int> tempOne = GroupTemperaturesByBand([5, 12, 25, 30, 8]);
        Console.WriteLine(tempOne["cold"] == 2);
        Console.WriteLine(tempOne["mild"] == 1);
        Console.WriteLine(tempOne["hot"] == 2);

        Dictionary<string, int> tempTwo = GroupTemperaturesByBand([15, 16, 20]);
        Console.WriteLine(tempTwo["mild"] == 3);
        Console.WriteLine(tempTwo.ContainsKey("cold") == false);
        Console.WriteLine(tempTwo.ContainsKey("hot") == false);

        Dictionary<string, int> tempThree = GroupTemperaturesByBand(null!);
        Console.WriteLine(tempThree.Count == 0);

        // SUm Valid Payment Amounts
        Console.WriteLine(SumValidPaymentAmounts("Paul:20, Sarah:35, Bob:abc") == 55);
        Console.WriteLine(SumValidPaymentAmounts("Paul:10, :50, Tom:5") == 15);
        Console.WriteLine(SumValidPaymentAmounts("BadRecord, Sam:-5, Amy:30") == 30);
        Console.WriteLine(SumValidPaymentAmounts("Paul:0, Sarah:10") == 10);
        Console.WriteLine(SumValidPaymentAmounts("Bad, AlsoBad") == 0);
        Console.WriteLine(SumValidPaymentAmounts("") == 0);
        Console.WriteLine(SumValidPaymentAmounts(" ") == 0);
        Console.WriteLine(SumValidPaymentAmounts(null) == 0);

        // Find Largest Jump Between Adjacent Numbers. 
        Console.WriteLine(FindLargestJumpBetweenAdjacentNumbers([3, 10, 6, 20]) == 14);
        Console.WriteLine(FindLargestJumpBetweenAdjacentNumbers([5, 5, 5]) == 0);
        Console.WriteLine(FindLargestJumpBetweenAdjacentNumbers([-5, 5, -10]) == 15);
        Console.WriteLine(FindLargestJumpBetweenAdjacentNumbers([7]) == null);
        Console.WriteLine(FindLargestJumpBetweenAdjacentNumbers(null!) == null);
        Console.WriteLine(FindLargestJumpBetweenAdjacentNumbers([]) == null);

        //Mask Middle Character
        // Console.WriteLine(MaskMiddleCharacters("Paul") == "P**l");
        // Console.WriteLine(MaskMiddleCharacters("coding") == "c****g");
        // Console.WriteLine(MaskMiddleCharacters("ab") == "ab");
        // Console.WriteLine(MaskMiddleCharacters("a") == "a");
        // Console.WriteLine(MaskMiddleCharacters("") == "");
        // Console.WriteLine(MaskMiddleCharacters(" ") == "");
        // Console.WriteLine(MaskMiddleCharacters(null!) == "");

        // Count Numbers With Same Parity As Their Index
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([2, 3, 4, 7]) == 4);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([1, 2, 3, 4]) == 0);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([0, 5, 8, 10]) == 3);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex(null!) == 0);
        // Console.WriteLine(CountNumbersWithSameParityAsTheirIndex([]) == 0);

        // ChallengeSolutionsRunner.Run_Four_Dictionary_Work()
        // RunnerChecks.Run();
        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
