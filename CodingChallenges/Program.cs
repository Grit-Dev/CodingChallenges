public class Program
{
    public static int CountingVowels(string pInput)
    {
        char[] vowels = { 'a', 'e', 'i', 'u', 'o' };
        pInput = pInput.ToLower().Trim();
        int counter = 0;

        foreach (char characters in pInput)
        {
            if (vowels.Contains(characters))
            {
                counter++;
            }
        }

        var count = vowels.Count(x => char.IsDigit(x));

        return counter;
        
    }

    public static bool IsPalindrome(string pInput)
    {
        pInput = pInput.ToLower().Trim();

        int left = 0;
        int right = pInput.Length - 1;

        while (left < right)
        {
            if (pInput[left] != pInput[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }

    public static int CountDigitsFromString(string pStringValue)
    {
        int counter = 0;

        if (pStringValue == null)
        {
            return 0;
        }

        foreach (char character in pStringValue)
        {
            if (char.IsDigit(character))
            {
                counter++;
            }
        }

        return counter; ;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello vowels are: {CountingVowels("Hello")}");
        Console.WriteLine($"Cyberpunk vowels are: {CountingVowels("Cyberpunk")}");
        Console.WriteLine($"APPLE vowels are: {CountingVowels("APPLE")}");
        Console.WriteLine($" \"\" vowels are: {CountingVowels("")}");
        Console.WriteLine($" Why vowels are: {CountingVowels("why")}");

        Console.WriteLine($"RaceCar outcome for Palindrome: {IsPalindrome("RaceCar")}");

        Console.WriteLine($"Count Digits From string should be 3 => Answer: {CountDigitsFromString("abc123")}");
    }
}
