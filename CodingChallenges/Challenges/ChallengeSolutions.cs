namespace CodingChallenges.Challenge
{
    // PMG TODO: Fix up & Refactor
    public class ChallengeSolutions
    {
        private int CountDigitsFromString(string pInputValue)
        {
            int count = 0;

            if (string.IsNullOrEmpty(pInputValue))
            {
                return count;
            }


            foreach (char character in pInputValue)
            {
                if (char.IsDigit(character))
                {
                    count++;
                }
            }

            return count;
        }

        private string ReverseString(string pInputValue)
        {
            string answer = string.Empty;

            if (String.IsNullOrEmpty(pInputValue))
            {
                return "Input is empty. Please ensure value is sent in.";
            }

            for (int counter = pInputValue.Length - 1; counter >= 0; counter--)
            {
                answer = answer + pInputValue[counter];
            }


            return answer;
        }

        private int CountingVowels(string pInputValue)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;

            if (string.IsNullOrEmpty(pInputValue))
            {
                return count;
            }

            pInputValue = pInputValue.ToLower().Trim();

            foreach (var character in pInputValue)
            {
                if (vowels.Contains(character))
                {
                    count++;
                }
            }

            return (count);

        }

        private bool IsPalindrome(string pInputValue)
        {
            int leftCounter = 0;
            int rightCounter = pInputValue.Length - 1;


            if (pInputValue == null)
            {
                return false;
            }

            pInputValue = pInputValue.ToLower().Replace(" ", "");

            while (leftCounter < rightCounter)
            {
                if (pInputValue[leftCounter] != pInputValue[rightCounter])
                {
                    return false;
                }

                leftCounter++;
                rightCounter--;
            }

            return true;

        }

        private int LargestNumber(int[] pInput)
        {

            if (pInput == null || pInput.Length == 0)
            {
                return 0;
            }

            int answer = pInput[0];

            for (int counter = 1; counter < pInput.Length; counter++)
            {
                if (pInput[counter] > answer)
                {
                    answer = pInput[counter];
                }
            }

            return answer;
        }

        private int SumEvenNumbers(int[] pInput)
        {
            int total = 0;

            if (pInput == null || pInput.Length == 0)
            {
                return 0;
            }

            foreach (int value in pInput)
            {
                if (value % 2 == 0)
                {
                    total = total + value;
                }
            }

            return total;


        }

        private int CountingSpaces(string pInputValue)
        {
            const int ZERO = 0;
            int total = 0;

            if (pInputValue == null)
            {
                return ZERO;
            }

            foreach (char characters in pInputValue)
            {
                if (char.IsWhiteSpace(characters))
                {
                    total++;
                }
            }

            return total;
        }

        private int CountingCapitalLetters(string pInputValue)
        {
            int counter = 0;

            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            foreach (char characters in pInputValue)
            {
                if (char.IsUpper(characters))
                {
                    counter++;
                }
            }

            return counter;
        }

        private int CountingWords(string pInputValue)
        {
            int counter = 0;
            bool isInsiderWorld = false;

            foreach (char characters in pInputValue)
            {
                if (char.IsWhiteSpace(characters) == false)
                {
                    if (isInsiderWorld == false)
                    {
                        counter++;
                        isInsiderWorld = true;
                    }
                }
                else
                {
                    isInsiderWorld = false;
                }
            }

            return counter;
        }

        private int SmallestNumber(int[]? pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int smallestNumber = pInputValue[0];

            foreach (int value in pInputValue)
            {
                if (value < smallestNumber)
                {
                    smallestNumber = value;
                }
            }

            return smallestNumber;

        }

        private string CountVowelsAndConsonants(string pInputValue)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            char[] consonants =
            {
            'b', 'c', 'd', 'f', 'g',
            'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's',
            't', 'v', 'w', 'x', 'y', 'z'
        };

            int vowelsTotal = 0;
            int Consonantstotal = 0;

            if (string.IsNullOrEmpty(pInputValue))
            {
                return $"Vowels Are Empty: {vowelsTotal} + Consonants Are Empty: {Consonantstotal}";
            }

            pInputValue = pInputValue.ToLower();

            foreach (char characters in pInputValue)
            {
                if (vowels.Contains(characters))
                {
                    vowelsTotal++;
                }
                if (consonants.Contains(characters))
                {
                    Consonantstotal++;
                }
            }

            return ($"Vowels: {vowelsTotal} + Consonants: {Consonantstotal})");
        }

        private int CharacterOccurrences(string? pInputValue, char pTargetCharacter)
        {
            int counter = 0;

            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            if (char.IsWhiteSpace(pTargetCharacter)
                || char.IsDigit(pTargetCharacter))
            {
                return 0;
            }

            pInputValue = pInputValue.ToLower();
            pTargetCharacter = char.ToLower(pTargetCharacter);

            foreach (char character in pInputValue)
            {
                if (character == pTargetCharacter)
                {
                    counter++;
                }
            }

            return counter;
        }

        private int[] TwoSum(int[] pNums, int pTarget)
        {

            if (pNums == null || pNums.Length == 0)
            {
                return [0, 0];
            }

            for (int counter = 0; counter <= pNums.Length - 1; counter++)
            {
                for (int counterTwo = counter + 1; counterTwo <= pNums.Length - 1; counterTwo++)
                {
                    if (pNums[counter] + pNums[counterTwo] == pTarget)
                    {
                        return new int[] { counter, counterTwo };
                    }
                }
            }

            return [0, 0];

        }

        public static int CountPositiveNumbers(int[] pInputValue)
        {
            int counter = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            foreach (int value in pInputValue)
            {
                if (value > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int CountingWordsRev(string pInputValue)
        {
            int counter = 0;
            bool insiderWord = false;

            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            foreach (char character in pInputValue)
            {
                if (char.IsWhiteSpace(character) == false)
                {
                    if (insiderWord == false)
                    {
                        counter++;
                        insiderWord = true;
                    }
                }
                else
                {
                    insiderWord = false;
                }
            }

            return counter;
        }

        public static int[] TwoSumRev(int[] pInputValue, int pTarget)
        {

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [0, 0];
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                for (int counterTwo = counter + 1; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (pInputValue[counter] + pInputValue[counterTwo] == pTarget)
                    {
                        return [counter, counterTwo];
                    }
                }
            }

            return [0, 0];
        }

        public static int FindFirstRepeatedNumber(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                for (int counterTwo = counter + 1; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (pInputValue[counter] == pInputValue[counterTwo])
                    {
                        return pInputValue[counter];
                    }
                }

            }

            return 0;
        }

        public static char FindFirstNonRepeatingCharacter(string pInputeValue)
        {
            if (string.IsNullOrEmpty(pInputeValue))
            {
                return '_';
            }

            pInputeValue = pInputeValue.ToLower().Trim();

            for (int counter = 0; counter <= pInputeValue.Length - 1; counter++)
            {
                int repeatedCharCounter = 0;

                for (int counterTwo = 0; counterTwo <= pInputeValue.Length - 1; counterTwo++)
                {
                    if (pInputeValue[counter] == pInputeValue[counterTwo])
                    {
                        repeatedCharCounter++;
                    }

                }

                if (repeatedCharCounter == 1)
                {
                    return pInputeValue[counter];
                }
            }

            return '_';
        }

        public static int CountNegativeNumbers(int[] pInputValue)
        {
            int counter = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            foreach (int value in pInputValue)
            {
                if (value < 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static char FindFirstNonRepeatingCharacterRev(string pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return '_';
            }

            pInputValue = pInputValue.ToLower().Trim();

            for (int counter = 0; counter < pInputValue.Length; counter++)
            {
                int charCounter = 0;

                for (int counterTwo = 0; counterTwo < pInputValue.Length; counterTwo++)
                {
                    if (pInputValue[counter] == pInputValue[counterTwo])
                    {
                        charCounter++;
                    }
                }

                if (charCounter == 1)
                {
                    return pInputValue[counter];
                }
            }

            return '_';
        }

        public static int[] TwoSumRevision(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [0, 0];
            }

            for (int counter = 0; counter < pInputValue.Length; counter++)
            {
                for (int counterTwo = counter + 1; counterTwo < pInputValue.Length; counterTwo++)
                {
                    if (pInputValue[counter] + pInputValue[counterTwo] == pTarget)
                    {
                        return [counter, counterTwo];
                    }
                }
            }

            return [0, 0];
        }

        public static int FindMissingNumber(int[] pInputValue)
        {
            int expectedNumber = 1;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pInputValue[counter] != expectedNumber)
                {
                    return expectedNumber;
                }

                expectedNumber++;
            }

            return expectedNumber;
        }

        public static int[] RemoveDuplicateNumbers(int[] pInputValue)
        {
            var list = new List<int>();

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            foreach (int number in pInputValue)
            {
                if (!list.Contains(number))
                {
                    list.Add(number);
                }
            }

            return list.ToArray();
        }

        public void RunAllChallengeSolutions()
        {
            // Remove Duplicate numbers:
            Console.WriteLine($"[1, 2, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 1, 2, 2, 3 }))}]");
            Console.WriteLine($"[5, 5, 5] should return [5] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 5, 5, 5 }))}]");
            Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 1, 2, 3 }))}]");
            Console.WriteLine($"[4, 1, 4, 2, 1] should return [4, 1, 2] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { 4, 1, 4, 2, 1 }))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(new int[] { }))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(null))}]");


            // Find missing number: You are given numbers from 1 to n, but one number is missing.
            Console.WriteLine($"[1, 2, 4, 5] should return 3 => Answer: {FindMissingNumber([1, 2, 4, 5])}");
            Console.WriteLine($"[1, 3, 4, 5] should return 2 => Answer: {FindMissingNumber([1, 3, 4, 5])}");
            Console.WriteLine($"[2, 3, 4, 5] should return 1 => Answer: {FindMissingNumber([2, 3, 4, 5])}");
            Console.WriteLine($"[1, 2, 3, 4] should return 5 => Answer: {FindMissingNumber([1, 2, 3, 4])}");
            Console.WriteLine($"[1, 2, 3, 5, 6] should return 4 => Answer: {FindMissingNumber([1, 2, 3, 5, 6])}");
            Console.WriteLine($"Empty array should return 0 => Answer: {FindMissingNumber([])}");
            Console.WriteLine($"Null should return 0 => Answer: {FindMissingNumber(null)}");

            // Two Sum Revision:
            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 2, 7, 11, 15 }, 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 4, 5 }, 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 3, 2, 4 }, 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 3, 3 }, 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRevision(new int[] { 1, 8, 10, 2 }, 10))}]");


            //// Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacterRev("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacterRev("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacterRev("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacterRev("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacterRev("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacterRev(null)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacterRev("Cyberpunk")}");

            //// Count Negative Numbers: 
            Console.WriteLine(CountNegativeNumbers([1, -2, 3, -4, 5]));
            Console.WriteLine(CountNegativeNumbers([-1, -2, -3]));
            Console.WriteLine(CountNegativeNumbers([0, 0, 0]));
            Console.WriteLine(CountNegativeNumbers([10]));
            Console.WriteLine(CountNegativeNumbers([]));
            Console.WriteLine(CountNegativeNumbers(null));

            // Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacter("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacter("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacter("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacter("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacter("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacter(null)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacter("Cyberpunk")}");

            // Find First Repeated Numbers
            Console.WriteLine($"[1, 2, 3, 2] should return 2 => Answer: {FindFirstRepeatedNumber(new int[] { 1, 2, 3, 2 })}");
            Console.WriteLine($"[5, 1, 5, 2] should return 5 => Answer: {FindFirstRepeatedNumber(new int[] { 5, 1, 5, 2 })}");
            Console.WriteLine($"[4, 4, 4] should return 4 => Answer: {FindFirstRepeatedNumber(new int[] { 4, 4, 4 })}");
            Console.WriteLine($"[1, 2, 3] should return 0 => Answer: {FindFirstRepeatedNumber(new int[] { 1, 2, 3 })}");
            Console.WriteLine($"Empty array should return 0 => Answer: {FindFirstRepeatedNumber(new int[] { })}");
            Console.WriteLine($"Null should return 0 => Answer: {FindFirstRepeatedNumber(null)}");

            // Count Positive Numbers
            Console.WriteLine(CountPositiveNumbers([1, -2, 3, 0, 5]));
            Console.WriteLine(CountPositiveNumbers([-1, -2, -3]));
            Console.WriteLine(CountPositiveNumbers([0, 0, 0]));
            Console.WriteLine(CountPositiveNumbers([10]));
            Console.WriteLine(CountPositiveNumbers(null));
            Console.WriteLine(CountPositiveNumbers([]));

            // TwoSumRev
            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 2, 7, 11, 15 }, 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 4, 5 }, 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 3, 2, 4 }, 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 3, 3 }, 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRev(new int[] { 1, 8, 10, 2 }, 10))}]");

            // CountingWordsRev
            Console.WriteLine($"Should be 1. Result: {CountingWordsRev(" One ")}");
            Console.WriteLine($"Should be 1. Result: {CountingWordsRev("One ")}");
            Console.WriteLine($"Should be 2. Result: {CountingWordsRev(" Hello World ")}");
            Console.WriteLine($"Should be 6. Result: {CountingWordsRev(" I went for a walk today ")}");

            // Counting Vowels
            Console.WriteLine($"Hello vowels are: {CountingVowels("Hello")}");
            Console.WriteLine($"Cyberpunk vowels are: {CountingVowels("Cyberpunk")}");
            Console.WriteLine($"APPLE vowels are: {CountingVowels("APPLE")}");
            Console.WriteLine($" \"\" vowels are: {CountingVowels("")}");
            Console.WriteLine($" Why vowels are: {CountingVowels("why")}");


            //Palindrome: 
            Console.WriteLine($"RaceCar outcome for Palindrome: {IsPalindrome("RaceCar")}");


            //// Counting Digits:
            Console.WriteLine($"Count Digits From string should be 3 => Answer: {CountDigitsFromString("abc123")}");

            // ReverseString:
            Console.WriteLine($"Reverse String => olleh Answer: {ReverseString("Hello")}");

            // Find the Largest number: 
            Console.WriteLine($"Largest number => [100, 1, 99 ] Answer: {LargestNumber([100, 1, 99])}");


            // Sum of Even Numbers
            Console.WriteLine($"Sum of Even Numbers  => [1, 2, 3, 4, 5] Answer = 6: {SumEvenNumbers([1, 2, 3, 4,])}");

            //CountSpaces
            Console.WriteLine($"Should be 7. Result: {CountingSpaces("       ")}");
            Console.WriteLine($"Should be 3. Result: {CountingSpaces(" Hello World ")}");
            Console.WriteLine($"Should be 0. Result: {CountingSpaces("")}");
            Console.WriteLine($"Should be 1. Result: {CountingSpaces(" ")}");

            // Counting Capitals:
            Console.WriteLine($"Should be 1. Result: {CountingCapitalLetters(" One ")}");
            Console.WriteLine($"Should be 1. Result: {CountingCapitalLetters("One ")}");
            Console.WriteLine($"Should be 2. Result: {CountingCapitalLetters(" Hello World ")}");
            Console.WriteLine($"Should be 9. Result: {CountingCapitalLetters(" I WENT for a WALK today ")}");

            // Counting Words: 
            Console.WriteLine($"Should be 1. Result: {CountingWords(" One ")}");
            Console.WriteLine($"Should be 1. Result: {CountingWords("One ")}");
            Console.WriteLine($"Should be 2. Result: {CountingWords(" Hello World ")}");
            Console.WriteLine($"Should be 6. Result: {CountingWords(" I went for a walk today ")}");

            // Smallest Number
            Console.WriteLine($"Smallest number should be 1 => Answer: {SmallestNumber([1, 5, 3, 9, 2])}");
            Console.WriteLine($"Smallest number should be -10 => Answer: {SmallestNumber([-5, -2, -10])}");
            Console.WriteLine($"Smallest number should be 100 => Answer: {SmallestNumber([100])}");
            Console.WriteLine($"Smallest number should be 4 => Answer: {SmallestNumber([4, 4, 4])}");
            Console.WriteLine($"Smallest number should be -100 => Answer: {SmallestNumber([50, 20, -100, 3])}");
            Console.WriteLine($"Smallest number should be 0 => Answer: {SmallestNumber([])}");
            Console.WriteLine($"Smallest number should be 0 => Answer: {SmallestNumber(null)}");

            // Counting Vowels and Consonants
            Console.WriteLine($"hello should be vowels: 2, consonants: 3 => Answer: {CountVowelsAndConsonants("hello")}");
            Console.WriteLine($"APPLE should be vowels: 2, consonants: 3 => Answer: {CountVowelsAndConsonants("APPLE")}");
            Console.WriteLine($"Cyberpunk 2077 should be vowels: 2, consonants: 7 => Answer: {CountVowelsAndConsonants("Cyberpunk 2077")}");
            Console.WriteLine($"Empty string should be vowels: 0, consonants: 0 => Answer: {CountVowelsAndConsonants("")}");
            Console.WriteLine($"Null should be vowels: 0, consonants: 0 => Answer: {CountVowelsAndConsonants(null)}");
            Console.WriteLine($"Why should be vowels: 0, consonants: 3 => Answer: {CountVowelsAndConsonants("Why")}");

            // Counting Character Occurrences
            // Create a method that takes a string and a character, then returns how many times that character appears.
            Console.WriteLine(CharacterOccurrences("hello", 'l'));
            Console.WriteLine(CharacterOccurrences("Cyberpunk", 'y'));
            Console.WriteLine(CharacterOccurrences("APPLE", 'p'));
            Console.WriteLine(CharacterOccurrences("aaaa", 'a'));
            Console.WriteLine(CharacterOccurrences("", 'a'));
            Console.WriteLine(CharacterOccurrences("null", 'a'));

            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSum(new int[] { 2, 7, 11, 15 }, 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSum(new int[] { 4, 5 }, 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSum(new int[] { 3, 2, 4 }, 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSum(new int[] { 3, 3 }, 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSum(new int[] { 1, 8, 10, 2 }, 10))}]");
        }
    }
}
