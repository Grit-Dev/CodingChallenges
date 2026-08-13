using System.Security.Cryptography.X509Certificates;

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

    public static int CountStrongPasswords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        int strongPasswordCounter = 0;
        string[] stringSplit = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in stringSplit)
        {
            int charIsUpperCounter = 0;
            int charIsLowerCounter = 0;
            int charIsDigitCounter = 0;

            string strTrimmed = str.Trim();

            if (strTrimmed.Contains(' '))
            {
                continue;
            }

            if (strTrimmed.Length >= 8)
            {
                foreach (char character in strTrimmed)
                {
                    if (char.IsUpper(character))
                    {
                       charIsUpperCounter++;          
                    }

                    if (char.IsLower(character))
                    {
                        charIsLowerCounter++;
                    }

                    if (char.IsDigit(character))
                    {
                        charIsDigitCounter++;
                    }
                }
            }

            if (charIsUpperCounter > 0 && charIsLowerCounter > 0 && charIsDigitCounter > 0)
            {
                strongPasswordCounter++;
            }
        }

        return strongPasswordCounter;
    }
    public static void Main(string[] args)
    {

        // Count Strong Passwords
        Console.WriteLine(CountStrongPasswords("Password1, hello, TEST1234, GoodPass9") == 2);
        Console.WriteLine(CountStrongPasswords("abc, 12345678, NoDigitsHere") == 0);
        Console.WriteLine(CountStrongPasswords("Aa123456") == 1);
        Console.WriteLine(CountStrongPasswords("") == 0);
        Console.WriteLine(CountStrongPasswords("   ") == 0);
        Console.WriteLine(CountStrongPasswords(null!) == 0);

        // Has Balanced Parentheses Rev Two
        //Console.WriteLine(HasBalancedParentheses_RevTwo("(Hello)") == true);
        //Console.WriteLine(HasBalancedParentheses_RevTwo("((Hello))") == true);
        //Console.WriteLine(HasBalancedParentheses_RevTwo("))Hello)") == false);
        //Console.WriteLine(HasBalancedParentheses_RevTwo("((Hello)") == false);
        //Console.WriteLine(HasBalancedParentheses_RevTwo(")hello)") == false);
        //Console.WriteLine(HasBalancedParentheses_RevTwo("Hello)") == false);
        //Console.WriteLine(HasBalancedParentheses_RevTwo("") == true);


        // ChallengeSolutionsRunner.Run_Three();
        // JsonDataSanitizerRunner.Run();
    }

}
