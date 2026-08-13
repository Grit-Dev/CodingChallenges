public class Program
{
    public static bool HasBalancedParentheses_RevTwo(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return true;
        }

        int balance = 0;

        foreach (char character in input)
        {
            if (character == '(')
            {
                balance++;
            }
            else if (character == ')')
            {
                balance--;


                if (balance < 0)
                {
                    return false;
                }
            }
        }

        return balance == 0;
    }
    public static void Main(string[] args)
    {
        // Has Balanced Parentheses Rev Two
        Console.WriteLine(HasBalancedParentheses_RevTwo("(Hello)") == true);
        Console.WriteLine(HasBalancedParentheses_RevTwo("((Hello))") == true);
        Console.WriteLine(HasBalancedParentheses_RevTwo("))Hello)") == false);
        Console.WriteLine(HasBalancedParentheses_RevTwo("((Hello)") == false);
        Console.WriteLine(HasBalancedParentheses_RevTwo(")hello)") == false);
        Console.WriteLine(HasBalancedParentheses_RevTwo("Hello)") == false);
        Console.WriteLine(HasBalancedParentheses_RevTwo("") == true);


        // ChallengeSolutionsRunner.Run_Three();
        // JsonDataSanitizerRunner.Run();
    }

}
