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
            if (char.ToLower(stringBuilder[left]) != char.ToLower(stringBuilder[right]))
            {
                return false;
            }
        }

        return true;   
    }

    public static void Main(string[] args)
    {
        // Revision: Is Palindrome Ignoring Spaces And Case


        // Remove Vowels Preserving Casing
        Console.WriteLine(RemoveVowelsPreserveCasing("hello"));
        Console.WriteLine(RemoveVowelsPreserveCasing("Cyberpunk 2077"));
        Console.WriteLine(RemoveVowelsPreserveCasing("APPLE"));
        Console.WriteLine(RemoveVowelsPreserveCasing("Why"));
        Console.WriteLine(RemoveVowelsPreserveCasing(null!));


        // Count Digits in String
        //Console.WriteLine(CountDigitsInString("abc123"));
        //Console.WriteLine(CountDigitsInString("Cyberpunk 2077"));
        //Console.WriteLine(CountDigitsInString("hello"));
        //Console.WriteLine(CountDigitsInString(""));
        //Console.WriteLine(CountDigitsInString(null!));
    }
}
