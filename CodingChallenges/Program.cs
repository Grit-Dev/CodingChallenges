using System.Text;

public class Program
{
    public static int CountDigitsInString(string pInputValue)
    {
        if(string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsDigit(character))
            {
                count++;
            }
        }

        return count;
    }

    public static string RemoveVowelsPreserveCasing(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        char[] vowels = ['a', 'e', 'i', 'o', 'u'];
        StringBuilder stringBuilder = new();

        foreach (char character in pInputValue)
        {
            if (!vowels.Contains(char.ToLower(character)))
            {
                stringBuilder.Append(character);
            }
        }

        return stringBuilder.ToString();
    }

    public static bool IsPalindromeIgnoringSpacesAndCase(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return false;
        }

        StringBuilder stringBuilder = new StringBuilder();

        foreach (char character in pInputValue)
        {
            if (!char.IsWhiteSpace(character))
            {
                stringBuilder.Append(character);
            }
        }

        int left = 0;
        int right = stringBuilder.Length - 1;

        while (left < right)
        {
            if (char.ToLower(stringBuilder[left]) != 
                char.ToLower(stringBuilder[right]))
            {
                return false;
            }

            left++;
            right--;
        }

        return true;   
    }

    public static int CountSpecialCharacter(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int counter = 0;

        foreach (char character in pInputValue)
        {
            if (!char.IsLetterOrDigit(character) && 
                !char.IsWhiteSpace(character))
            {
                counter++;
            }
        }

        return counter;
    }

    public static string RemoveDigitsFromString(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder stringBuilder = new();

        foreach (char character in pInputValue)
        {
            if (!char.IsDigit(character))
            {
                stringBuilder.Append(character);
            }
        }

        if (string.IsNullOrEmpty(stringBuilder.ToString()))
        {
            return "";
        }

        return stringBuilder.ToString();

    }

    public static int CountSpecialCharacters(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;

        foreach (char character in pInputValue)
        {
            if (!char.IsLetterOrDigit(character) && !char.IsWhiteSpace(character))
            {
                count++;
            }
        }

        return count;
    }

    public static string CompressRepeatedCharacter(string pInputValue)
    {
        if (string.IsNullOrEmpty(pInputValue))
        {
            return "";
        }

        StringBuilder stringBuilder = new();
        char oldChar = '\0';

        for (int outerIndex = 0; outerIndex <= pInputValue.Length - 1; outerIndex++)
        {
            char value = pInputValue[outerIndex];
            int currentValue = 0;
            int count = 0;

            for (int innerIndex = 0; innerIndex <= pInputValue.Length - 1; innerIndex++)
            {

                if (value == pInputValue[innerIndex] && currentValue == 0 && oldChar != value)
                {
                    stringBuilder.Append(value);
                    currentValue++;
                    count++;
                }
                else if (value == pInputValue[innerIndex] && oldChar != value)
                {
                    count++;
                }
            }

            if (oldChar != value)
            { 
                stringBuilder.Append(count);
            }

            oldChar = value;
        }

        return stringBuilder.ToString();

    }

    public static void Main(string[] args)
    {
        // Compress Repeated Characters:
        Console.WriteLine(CompressRepeatedCharacter("aaabbc"));
        Console.WriteLine(CompressRepeatedCharacter("hello"));
        Console.WriteLine(CompressRepeatedCharacter("a"));
        Console.WriteLine(CompressRepeatedCharacter("a1"));
        Console.WriteLine(CompressRepeatedCharacter(""));
        Console.WriteLine(CompressRepeatedCharacter(null!));



        // Remove Digits From String
        //Console.WriteLine(RemoveDigitsFromString("abc123"));
        //Console.WriteLine(RemoveDigitsFromString("abc"));
        //Console.WriteLine(RemoveDigitsFromString("Cyberpunk 2077"));
        //Console.WriteLine(RemoveDigitsFromString("12345"));
        //Console.WriteLine(RemoveDigitsFromString(""));
        //Console.WriteLine(RemoveDigitsFromString(null!));


        // Count Special Characters
        //Console.WriteLine(CountSpecialCharacter("hello!"));
        //Console.WriteLine(CountSpecialCharacter("C# is fun!"));
        //Console.WriteLine(CountSpecialCharacter("abc123"));
        //Console.WriteLine(CountSpecialCharacter("@Adam_Smasher!"));
        //Console.WriteLine(CountSpecialCharacter(""));
        //Console.WriteLine(CountSpecialCharacter(null!));


        // Revision: Is Palindrome Ignoring Spaces And Case
        //Console.WriteLine(IsPalindromeIgnoringSpacesAndCase("racecar"));
        //Console.WriteLine(IsPalindromeIgnoringSpacesAndCase("Race Car"));
        //Console.WriteLine(IsPalindromeIgnoringSpacesAndCase("never odd or even"));
        //Console.WriteLine(IsPalindromeIgnoringSpacesAndCase("hello"));
        //Console.WriteLine(IsPalindromeIgnoringSpacesAndCase(""));
        //Console.WriteLine(IsPalindromeIgnoringSpacesAndCase(null!));


        // Remove Vowels Preserving Casing
        //Console.WriteLine(RemoveVowelsPreserveCasing("hello"));
        //Console.WriteLine(RemoveVowelsPreserveCasing("Cyberpunk 2077"));
        //Console.WriteLine(RemoveVowelsPreserveCasing("APPLE"));
        //Console.WriteLine(RemoveVowelsPreserveCasing("Why"));
        //Console.WriteLine(RemoveVowelsPreserveCasing(null!));


        // Count Digits in String
        //Console.WriteLine(CountDigitsInString("abc123"));
        //Console.WriteLine(CountDigitsInString("Cyberpunk 2077"));
        //Console.WriteLine(CountDigitsInString("hello"));
        //Console.WriteLine(CountDigitsInString(""));
        //Console.WriteLine(CountDigitsInString(null!));
    }
}
