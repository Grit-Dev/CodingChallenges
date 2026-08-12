
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
    public static void Main(string[] args)
    {
        // Has Balance Parentheses Rev
        Console.WriteLine(HasBalancedParentheses_Rev("(hello)") == true);
        Console.WriteLine(HasBalancedParentheses_Rev("hello (world)") == true);
        Console.WriteLine(HasBalancedParentheses_Rev("(hello (world))") == true);
        Console.WriteLine(HasBalancedParentheses_Rev("hello)") == false);
        Console.WriteLine(HasBalancedParentheses_Rev("((hello)") == false);
        Console.WriteLine(HasBalancedParentheses_Rev(")hello(") == false);
        Console.WriteLine(HasBalancedParentheses_Rev("") == true);
        Console.WriteLine(HasBalancedParentheses_Rev(" ") == true);
        Console.WriteLine(HasBalancedParentheses_Rev(null!) == true);

        // VaultItemInheritanceRunner.Run();
        // CardShopCompositionChallenges.Run();
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
