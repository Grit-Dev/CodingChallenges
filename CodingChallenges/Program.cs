
using CodingChallenges.Challenges.Phase_02_OOP.Inheritance_Basics;

public class Program
{

    public static bool HasBalancedParentheses_Rev(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        int brackets = 0;

        foreach (var character in input)
        {
            if (character == '(')
            {
                brackets++;
            }
            else if (character == ')')
            {
                brackets--;

                if (brackets < 0)
                {
                    return false;
                }
            }
        }

        return brackets == 0;
    }

    public static bool HasBalancedSquareBrackets_Rev(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        int squareBrackets = 0;

        foreach (var character in input)
        {
            if (character == '[')
            {
                squareBrackets++;
            }
            else if (character == ']')
            {
                squareBrackets--;

                if (squareBrackets < 0)
                {
                    return false;
                }
            }
        }

        return squareBrackets == 0;
    }

    public static int? FindSecondHighestUniqueNumber_Rev(int[] numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return null;
        }

        int? highestNumber = null;
        int? secondHighestNumber = null;

        foreach (var digit in numbers)
        {
            if (highestNumber is null || digit > highestNumber)
            {
                secondHighestNumber = highestNumber;
                highestNumber = digit;
            }
            else if(digit != highestNumber && (secondHighestNumber is null 
            || digit > secondHighestNumber))
            {
                secondHighestNumber = digit;
            }
        }

        return secondHighestNumber;
    }
    public static void Main(string[] args)
    {
        // Find Second Highest Unique Number
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev([10, 20, 30]) == 20);
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev([10, 30, 30, 20]) == 20);
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev([5, 5, 5]) == null);
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev([100, 50, 100, 25]) == 50);
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev([-10, -5, -20]) == -10);
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev(null!) == null);
        Console.WriteLine(FindSecondHighestUniqueNumber_Rev([]) == null);

        // Has Balanced Square Brackets
        // Console.WriteLine(HasBalancedSquareBrackets_Rev("[hello]") == true);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev("hello [world]") == true);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev("hello]") == false);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev("[[hello]") == false);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev("]hello]") == false);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev("") == true);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev(" ") == true);
        // Console.WriteLine(HasBalancedSquareBrackets_Rev(null!) == true);

        // Has Balance Parentheses Rev
        // Console.WriteLine(HasBalancedParentheses_Rev("(hello)") == true);
        // Console.WriteLine(HasBalancedParentheses_Rev("hello (world)") == true);
        // Console.WriteLine(HasBalancedParentheses_Rev("(hello (world))") == true);
        // Console.WriteLine(HasBalancedParentheses_Rev("hello)") == false);
        // Console.WriteLine(HasBalancedParentheses_Rev("((hello)") == false);
        // Console.WriteLine(HasBalancedParentheses_Rev(")hello(") == false);
        // Console.WriteLine(HasBalancedParentheses_Rev("") == true);
        // Console.WriteLine(HasBalancedParentheses_Rev(" ") == true);
        // Console.WriteLine(HasBalancedParentheses_Rev(null!) == true);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
