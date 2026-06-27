using System.Text;

namespace CodingChallenges.Challenges
{
    // PMG TODO: Clean up and Refactor - Is getting a bit too big


    public class ChallengeSolutions
    {

        private static string RemoveVowels(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            var newStringInput = new StringBuilder();
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            pInputValue = pInputValue.ToLower();


            foreach (char character in pInputValue)
            {
                if (!vowels.Contains(character))
                {
                    newStringInput.Append(character);
                }
            }

            return newStringInput.ToString();
        }

        private static string CountVowelsAndConsonants(string pInputvalue)
        {
            if (string.IsNullOrEmpty(pInputvalue))
            {
                return "Vowels: 0, Consonants: 0";

            }

            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            char[] consonants =
            [
                'b', 'c', 'd', 'f', 'g',
                'h', 'j', 'k', 'l', 'm',
                'n', 'p', 'q', 'r', 's',
                't', 'v', 'w', 'x', 'y',
                'z'
            ];

            pInputvalue = pInputvalue.ToLower();

            int vowelsCounter = 0;
            int consonantsCounter = 0;

            foreach (char character in pInputvalue)
            {
                if (vowels.Contains(character))
                {
                    vowelsCounter++;
                }
                else if (consonants.Contains(character))
                {
                    consonantsCounter++;
                }
            }

            return $"Vowels: {vowelsCounter}, Consonants: {consonantsCounter}";

        }

        public static int CountLowerCaseLetters(string pInputVale)
        {
            if (string.IsNullOrEmpty(pInputVale))
            {
                return 0;
            }

            int counter = 0;

            foreach (char character in pInputVale)
            {
                if (char.IsLower(character))
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int CountWords(string pInputVale)
        {
            if (string.IsNullOrEmpty(pInputVale))
            {
                return 0;
            }

            bool isInsideWord = false;
            int counter = 0;

            foreach (char character in pInputVale)
            {
                if (!char.IsWhiteSpace(character))
                {
                    if (isInsideWord == false)
                    {
                        counter++;
                        isInsideWord = true;

                    }
                }
                else
                {
                    isInsideWord = false;
                }
            }

            return counter;
        }

        public static int FindLongestWordLength(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int longestLengthTotal = 0;
            int counter = 0;

            foreach (char character in pInputValue)
            {
                if (!char.IsWhiteSpace(character))
                {
                    counter++;
                }
                else
                {
                    if (counter > longestLengthTotal)
                    {
                        longestLengthTotal = counter;
                    }

                    counter = 0;
                }
            }

            if (counter > longestLengthTotal)
            {
                longestLengthTotal = counter;
            }

            return longestLengthTotal;
        }

        public static bool IsPalindromeIgnoringSpaces(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return false;
            }

            StringBuilder newString = new StringBuilder();

            foreach (char character in pInputValue)
            {
                if (!char.IsWhiteSpace(character))
                {
                    newString.Append(character);
                }
            }

            int left = 0;
            int right = newString.Length - 1;

            while (left <= right)
            {
                if (newString[left] != newString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public static int FindLongestWordLengthAnotherGo(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int longestStringCounter = 0;
            int counter = 0;

            foreach (char character in pInputValue)
            {
                if (!char.IsWhiteSpace(character))
                {
                    counter++;
                }
                else
                {
                    if (counter > longestStringCounter)
                    {
                        longestStringCounter = counter;
                    }
                }
            }

            if (counter > longestStringCounter)
            {
                longestStringCounter = counter;
            }

            return longestStringCounter;
        }

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

            if (string.IsNullOrEmpty(pInputValue))
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
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
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

            return count;

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

        private string CountVowelsAndConsonantsFriday(string pInputValue)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            char[] consonants =
            [
            'b', 'c', 'd', 'f', 'g',
            'h', 'j', 'k', 'l', 'm',
            'n', 'p', 'q', 'r', 's',
            't', 'v', 'w', 'x', 'y', 'z'
        ];

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

            return $"Vowels: {vowelsTotal} + Consonants: {Consonantstotal})";
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
                        return [counter, counterTwo];
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

        // NOTE: Was a revision Exercise
        //public static int FindMissingNumber(int[] pInputValue)
        //{
        //    int expectedNumber = 1;

        //    if (pInputValue == null || pInputValue.Length == 0)
        //    {
        //        return 0;
        //    }

        //    for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
        //    {
        //        if (pInputValue[counter] != expectedNumber)
        //        {
        //            return expectedNumber;
        //        }

        //        expectedNumber++;
        //    }

        //    return expectedNumber;
        //}


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

        public static int FindMissingNumber(int[] inputValue)
        {
            int incrementer = 1;

            if (inputValue == null || inputValue.Length == 0)
            {
                return 0;
            }

            foreach (int value in inputValue)
            {
                if (value != incrementer)
                {
                    return incrementer;
                }

                incrementer++;
            }

            return 0;
        }

        public static int FindTheSecondLargestNumber(int[] pInputValue)
        {
            int firstLargestNum = 0;
            int secondLargestNum = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            if (pInputValue.Length == 1)
            {
                return pInputValue[0];
            }

            firstLargestNum = pInputValue[0];
            secondLargestNum = pInputValue[0];

            foreach (int value in pInputValue)
            {
                if (value > firstLargestNum)
                {
                    secondLargestNum = firstLargestNum;
                    firstLargestNum = value;
                }
                if (value > secondLargestNum && value != firstLargestNum)
                {
                    secondLargestNum = value;
                }
            }

            return secondLargestNum;

        }

        public static int[] ReverseAnArray(int[] pInputValue)
        {
            int left = 0;
            int right = pInputValue.Length - 1;
            int tempHolder = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            while (left < right)
            {
                tempHolder = pInputValue[left];
                pInputValue[left] = pInputValue[right];
                pInputValue[right] = tempHolder;

                left++;
                right--;
            }

            return pInputValue;
        }

        public static bool IsSortedArrayAscending(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return false;
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                for (int counterTwo = counter + 1; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (pInputValue[counter] > pInputValue[counterTwo])
                    {
                        return false;
                    }
                }
            }


            return true;
        }

        public static int SumPositiveNumbers(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int total = 0;

            foreach (int value in pInputValue)
            {
                if (value > 0)
                {
                    total = total + value;
                }
            }

            return total;
        }

        public static int CountSecondLargestNumberRev(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int firstLargestNumber;
            int secondLargestNumber;

            if (pInputValue.Length == 1)
            {
                return pInputValue[0];
            }

            if (pInputValue[0] >= pInputValue[1])
            {
                firstLargestNumber = pInputValue[0];
                secondLargestNumber = pInputValue[1];
            }
            else
            {
                firstLargestNumber = pInputValue[1];
                secondLargestNumber = pInputValue[0];
            }

            for (int counter = 2; counter <= pInputValue.Length - 1; counter++)
            {
                int value = pInputValue[counter];

                if (value > firstLargestNumber)
                {
                    secondLargestNumber = firstLargestNumber;
                    firstLargestNumber = value;
                }
                else if (value > secondLargestNumber)
                {
                    secondLargestNumber = value;
                }
            }

            return secondLargestNumber;
        }

        public static int[] MergeArraysRev(int[] pInputValueOne, int[] pInputValueTwo)
        {
            if ((pInputValueOne == null || pInputValueOne.Length == 0)
            && (pInputValueTwo == null || pInputValueTwo.Length == 0))
            {
                return [];
            }
            else if (pInputValueOne == null || pInputValueOne.Length == 0)
            {
                return pInputValueTwo;
            }
            else if (pInputValueTwo == null || pInputValueTwo.Length == 0)
            {
                return pInputValueOne;
            }

            List<int> mergedArrayList = [];

            foreach (int value in pInputValueOne)
            {
                if (!mergedArrayList.Contains(value))
                {
                    mergedArrayList.Add(value);
                }
            }

            foreach (int value in pInputValueTwo)
            {
                if (!mergedArrayList.Contains(value))
                {
                    mergedArrayList.Add(value);
                }
            }

            return mergedArrayList.ToArray();
        }

        public static int FindIndexOfTarget(int[] pInputValue, int pTarget)
        {

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return -1;
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pInputValue[counter] == pTarget)
                {
                    return counter;
                }
            }

            return -1;
        }

        public static int CountNumbersInRange(int[] pInputValue, int pMin, int pMax)
        {
            int incrementor = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pInputValue[counter] >= pMin
                && pInputValue[counter] <= pMax)
                {
                    incrementor++;
                }
            }

            return incrementor;
        }

        public static int[] FilterNumbersBetweenRange(int[] pInputValue, int pMin, int pMax)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> filteredNumberList = [];

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pInputValue[counter] >= pMin && pInputValue[counter] <= pMax)
                {
                    filteredNumberList.Add(pInputValue[counter]);
                }
            }

            return filteredNumberList.ToArray();
        }


        public static int CountNumbersLessThanTarget(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int count = 0;

            foreach (int value in pInputValue)
            {
                if (value < pTarget)
                {
                    count++;
                }
            }

            return count;
        }

        public static int SumPositiveNumbersRev2(int[] pInputValue)
        {
            int total = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            foreach (int value in pInputValue)
            {
                if (value > 0)
                {
                    total = total + value;
                }
            }

            return total;
        }

        public static int[] MergeArrays(int[] pInputValueOne, int[] pInputValueTwo)
        {
            if ((pInputValueOne == null || pInputValueOne.Length == 0)
            && (pInputValueTwo == null || pInputValueTwo.Length == 0))
            {
                return [];
            }
            else if (pInputValueOne == null || pInputValueOne.Length == 0)
            {
                return pInputValueTwo;
            }
            else if (pInputValueTwo == null || pInputValueTwo.Length == 0)
            {
                return pInputValueOne;
            }

            List<int> mergedList = [];

            foreach (int valueOne in pInputValueOne)
            {
                mergedList.Add(valueOne);
            }

            foreach (int valueTwo in pInputValueTwo)
            {
                mergedList.Add(valueTwo);
            }

            return mergedList.ToArray();


        }

        public static int FindLastIndexOfTarget(int[] pInputValueOne, int pTarget)
        {
            if (pInputValueOne == null || pInputValueOne.Length == 0)
            {
                return -1;
            }

            for (int counter = pInputValueOne.Length - 1; counter >= 0; counter--)
            {
                if (pInputValueOne[counter] == pTarget)
                {
                    return counter;
                }
            }


            return -1;
        }

        public static int[] SplitPositiveAndNegativeNumbers(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> numberList = [];

            foreach (int value in pInputValue)
            {
                if (value > 0)
                {
                    numberList.Add(value);
                }
            }

            foreach (int value in pInputValue)
            {
                if (value < 0)
                {
                    numberList.Add(value);
                }
            }

            return numberList.ToArray();
        }

        public static int[] ReplaceTargetWithValue(int[] pInputValue, int target, int replacement)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            int[] newArray = new int[pInputValue.Length];

            for (int counter = 0; counter < pInputValue.Length; counter++)
            {
                if (pInputValue[counter] == target)
                {
                    newArray[counter] = replacement;
                }
                else
                {
                    newArray[counter] = pInputValue[counter];
                }
            }

            return newArray;
        }

        public static int SumEvenNumbersRev(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int total = 0;

            foreach (int value in pInputValue)
            {
                if (value % 2 == 0)
                {
                    total = total + value;
                }
            }

            return total;
        }

        public static int[] ReplaceTarget(int[] pInputValue, int pTarget, int pReplacement)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            var listArray = new List<int>();

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {

                if (pInputValue[counter] == pTarget)
                {
                    listArray.Add(pReplacement);
                }
                else
                {
                    listArray.Add(pInputValue[counter]);
                }
            }

            return listArray.ToArray();
        }

        public static int[] SplitPosNeg(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> listArray = [];

            foreach (int value in pInputValue)
            {
                if (value > 0)
                {
                    listArray.Add(value);
                }
            }

            foreach (int value in pInputValue)
            {
                if (value < 0)
                {
                    listArray.Add(value);
                }
            }

            return listArray.ToArray();
        }

        // 4. Count Matching Numbers
        // -Count how many times a target number appears in an array
        public static int CountMatching(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int counter = 0;

            foreach (int value in pInputValue)
            {
                if (value == pTarget)
                {
                    counter++;
                }
            }

            return counter;
        }
        public static int[] RemoveTarget(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> listArray = [];

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pInputValue[counter] != pTarget)
                {
                    listArray.Add(pInputValue[counter]);
                }
            }

            return listArray.ToArray();
        }
        public static int[] MoveTargetToEnd(int[] pInputeValue, int pTarget)
        {
            if (pInputeValue == null || pInputeValue.Length == 0)
            {
                return [];
            }

            List<int> listArray = [];

            foreach (int value in pInputeValue)
            {
                if (value != pTarget)
                {
                    listArray.Add(value);
                }
            }

            foreach (int value in pInputeValue)
            {
                if (value == pTarget)
                {
                    listArray.Add(value);
                }
            }

            return listArray.ToArray();
        }

        public static int CountNonZero(int[] pInputValue)
        {
            int counter = 0;

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            foreach (int value in pInputValue)
            {
                if (value != 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int[] MoveTargetToEndRev(int[] pInputValue, int pTarget)
        {
            List<int> listArray = [];

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            foreach (int value in pInputValue)
            {
                if (value != pTarget)
                {
                    listArray.Add(value);
                }
            }

            foreach (int value in pInputValue)
            {
                if (value == pTarget)
                {
                    listArray.Add(value);
                }
            }

            return listArray.ToArray();
        }

        public static int FindSecondLargestNumRev(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int firstLargestNumber;
            int secondLargestNumber;

            if (pInputValue.Length == 1)
            {
                return pInputValue[0];
            }

            if (pInputValue[0] >= pInputValue[1])
            {
                firstLargestNumber = pInputValue[0];
                secondLargestNumber = pInputValue[1];
            }
            else
            {
                firstLargestNumber = pInputValue[1];
                secondLargestNumber = pInputValue[0];
            }

            foreach (int value in pInputValue)
            {
                if (value > firstLargestNumber)
                {
                    secondLargestNumber = firstLargestNumber;
                    firstLargestNumber = value;
                }
                else if (value > secondLargestNumber)
                {
                    secondLargestNumber = value;
                }
            }

            return secondLargestNumber;
        }

        public static int MostFrequentNumberInArray(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int totalCountFound = 0;
            int FrequentValue = 0;

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                int value = pInputValue[counter];
                int count = 0;

                for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (value == pInputValue[counterTwo])
                    {
                        count++;
                    }

                    if (count > totalCountFound)
                    {
                        totalCountFound = count;
                        FrequentValue = value;
                    }
                }
            }

            return FrequentValue;
        }

        // 5. New Challenge: Rotating Array Right By One
        // Move the Last number to the front - New Sized array 
        // Example [1,2,3,4] -> [4,1,2,3]
        // [10, 20, 30] -> [30, 10, 20]
        // Put last value at index 0; Then
        // copy the rest of the orginal values one positon to 
        // the right

        public static int[] RotateArrayRight(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            int[] newArray = new int[pInputValue.Length];
            newArray[0] = pInputValue[pInputValue.Length - 1];

            for (int counter = 1; counter <= pInputValue.Length - 1; counter++)
            {

                newArray[counter] = pInputValue[counter - 1];
            }

            return newArray;
        }

        public static int[] RotateArrayLeft(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            int[] newArray = new int[pInputValue.Length];
            newArray[pInputValue.Length - 1] = pInputValue[0];


            for (int counter = 0; counter < pInputValue.Length - 1; counter++)
            {
                newArray[counter] = pInputValue[counter + 1];
            }


            return newArray;
        }

        // PMG TO DO: REFACTOR
        public static int CountNonZeroRev(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int counter = 0;

            foreach (int value in pInputValue)
            {
                if (value > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int[] RotateArrayToRight(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            int[] newArray = new int[pInputValue.Length];
            newArray[0] = pInputValue[pInputValue.Length - 1];

            for (int counter = 1; counter <= pInputValue.Length - 1; counter++)
            {
                newArray[counter] = pInputValue[counter - 1];
            }

            return newArray;
        }

        public static int[] MoveTargetToEndRevTwo(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> newList = [];

            foreach (int value in pInputValue)
            {
                if (value != pTarget)
                {
                    newList.Add(value);
                }
            }

            foreach (int value in pInputValue)
            {
                if (value == pTarget)
                {
                    newList.Add(value);
                }
            }

            return newList.ToArray();
        }

        public static int MostFrequentNumberInArrayRev(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int frequentHolderNumber = 0;
            int incrementor;
            int incrementorTotal = 0;

            // Exit early to save nested loop            
            if (pInputValue.Length == 1)
            {
                return pInputValue[0];
            }


            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                int value = pInputValue[counter];
                incrementor = 0;


                for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (value == pInputValue[counterTwo])
                    {
                        incrementor++;
                    }
                }

                if (incrementor > incrementorTotal)
                {
                    incrementorTotal = incrementor;
                    frequentHolderNumber = pInputValue[counter];
                }
            }

            return frequentHolderNumber;
        }

        public static int[] RotateArrayLeftRev(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            int[] newArray = new int[pInputValue.Length];
            newArray[pInputValue.Length - 1] = pInputValue[0];

            for (int counter = 0; counter < pInputValue.Length - 1; counter++)
            {
                newArray[counter] = pInputValue[counter + 1];
            }

            return newArray;
        }

        // 7 Remove First occurrence of target:
        // - Remove only the first matching target Value. 
        // Example: [1,5,10,5] Target: 5 => [1,10,5]
        public static int[] RemoveFirstOccurrence(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> newList = [];
            int counter = 0;

            foreach (int value in pInputValue)
            {
                if (value == pTarget && counter == 0)
                {
                    counter++;
                }
                else
                {
                    newList.Add(value);
                }
            }

            return newList.ToArray();
        }

        public static int[] RemoveLastOccurrence(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> newList = [];

            foreach (int value in pInputValue)
            {
                if (!newList.Contains(value))
                {
                    newList.Add(value);
                }

            }

            return newList.ToArray();
        }

        public static int[] RemoveLastOccurrenceReverseForLoop(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> newList = [];
            int count = 0;

            for (int counter = pInputValue.Length - 1; counter >= 0; counter--)
            {
                if (pInputValue[counter] == pTarget && count == 0)
                {
                    count++;
                }
                else
                {
                    newList.Add(pInputValue[counter]);
                }
            }

            newList.Reverse();
            return newList.ToArray();
        }

        public static int FindSecondLargestNumberRevTwo(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int firstLargestNumber;
            int secondLargestNumber;

            if (pInputValue.Length == 1)
            {
                return pInputValue[0];
            }

            if (pInputValue[0] >= pInputValue[1])
            {
                firstLargestNumber = pInputValue[0];
                secondLargestNumber = pInputValue[1];
            }
            else
            {
                firstLargestNumber = pInputValue[1];
                secondLargestNumber = pInputValue[0];
            }


            for (int counter = 2; counter <= pInputValue.Length - 1; counter++)
            {
                int value = pInputValue[counter];

                if (value > firstLargestNumber)
                {
                    secondLargestNumber = firstLargestNumber;
                    firstLargestNumber = value;
                }
                else if (value > secondLargestNumber)
                {
                    secondLargestNumber = value;
                }
            }


            return secondLargestNumber;
        }

        public static int CountNonZerosWarmUp(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int count = 0;

            foreach (int value in pInputValue)
            {
                if (value != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] RotateArrayRightByOne(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            int[] newArray = new int[pInputValue.Length];
            newArray[0] = pInputValue[pInputValue.Length - 1];

            for (int counter = 1; counter <= pInputValue.Length - 1; counter++)
            {
                newArray[counter] = pInputValue[counter - 1];
            }

            return newArray;
        }

        public static int[] RotateArrayLeftWarmUp(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            var newArray = new int[pInputValue.Length];
            newArray[pInputValue.Length - 1] = pInputValue[0];

            for (int counter = 0; counter < pInputValue.Length - 1; counter++)
            {
                newArray[counter] = pInputValue[counter + 1];
            }

            return newArray;
        }

        // Bug: Redo
        public static int MostFrequentNumberInArrayRevision(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }
            ;

            int mostFrequentNumber = 0;

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {

                int count = 0;
                int value = pInputValue[counter];

                for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (value == pInputValue[counterTwo])
                    {
                        count++;
                    }
                }

                if (count > mostFrequentNumber)
                {
                    mostFrequentNumber = value;
                }

            }

            return mostFrequentNumber;
        }

        public static int[] RemoveNegativeNumbers(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> newList = [];

            foreach (int counter in pInputValue)
            {
                if (counter >= 0)
                {
                    newList.Add(counter);
                }
            }

            return newList.ToArray();
        }

        public static int FindSecondLargestDistinctNumber(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return -1;
            }

            int firstLargestnumber = int.MinValue;
            int secondLargestnumber = int.MinValue;

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                int value = pInputValue[counter];

                if (value > firstLargestnumber)
                {
                    secondLargestnumber = firstLargestnumber;
                    firstLargestnumber = value;
                }
                else if (value > secondLargestnumber && value != firstLargestnumber)
                {
                    secondLargestnumber = value;
                }
            }

            if (secondLargestnumber == int.MinValue)
            {
                return -1;
            }

            return secondLargestnumber;
        }

        public static int FindFirstNumberGreaterThanTarget(int[] pInputValue, int pInputTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            foreach (int value in pInputValue)
            {
                if (value > pInputTarget)
                {
                    return value;
                }
            }

            return 0;
        }

        public static int FindLastNumberGreaterThanTarget(int[] pInputValue, int pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            for (int counter = pInputValue.Length - 1; counter >= 0; counter--)
            {
                if (pInputValue[counter] > pTarget)
                {
                    return pInputValue[counter];
                }
            }

            return 0;
        }

        public static int CountOddNumbersRevisionOne(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int counter = 0;

            foreach (int value in pInputValue)
            {
                if (value % 2 != 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static int MostFrequentNumberRevisionOne(int[] pInputValue)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return 0;
            }

            int mostFrequentNumber = 0;
            int highestCounter = 0;

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                int value = pInputValue[counter];
                int countFrequency = 0;

                for (int counterTwo = 0; counterTwo <= pInputValue.Length - 1; counterTwo++)
                {
                    if (value == pInputValue[counterTwo])
                    {
                        countFrequency++;
                    }
                }

                if (countFrequency > highestCounter)
                {
                    highestCounter = countFrequency;
                    mostFrequentNumber = value;
                }
            }

            return mostFrequentNumber;
        }

        public static int[] RemoveLastOccurrenceRevisionOne(int[] pInputValue, int? pTarget)
        {
            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            if (!pTarget.HasValue)
            {
                return [];
            }

            List<int> newList = [];
            bool isTrue = false;

            if (pInputValue.Length == 1)
            {
                if (pTarget == pInputValue[0])
                {
                    return [];
                }
                else
                {
                    newList.Add(pInputValue[0]);
                    return newList.ToArray();
                }
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pTarget == pInputValue[counter] && isTrue == false)
                {
                    newList.Add(pInputValue[counter]);
                    isTrue = true;
                }
                else if (pTarget != pInputValue[counter])
                {
                    newList.Add(pInputValue[counter]);
                }
            }

            return newList.ToArray();
        }

        public static void CountVowelsAndConsonantsRevisionOne(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                Console.WriteLine("Input cannot be null or empty                                                                                                                                                                                                          ");
            }

            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            char[] consonants =
            [
                'b','c','d','f','g','h','j','k','l','m',
                'n','p','q','r','s','t','v','w','x','y','z'
            ];
            int vowelsCounter = 0;
            int consonantsCounter = 0;

            pInputValue = pInputValue.ToLower();

            foreach (char counter in pInputValue)
            {
                if (vowels.Contains(counter))
                {
                    vowelsCounter++;
                }
                else if (consonants.Contains(counter))
                {
                    consonantsCounter++;
                }
            }

            Console.WriteLine("vowels: " + vowelsCounter);
            Console.WriteLine("Other" + consonantsCounter);
        }

        public static string RemoveSpaces(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            string newWord = "";

            foreach (char character in pInputValue)
            {
                if (!char.IsWhiteSpace(character))
                {
                    newWord = newWord + character;
                }
            }

            return newWord;
        }

        public static string ReverseStringRev(string pInputeValue)
        {
            if (string.IsNullOrEmpty(pInputeValue))
            {
                return "";
            }

            StringBuilder reversedString = new();

            for (int counter = pInputeValue.Length - 1; counter >= 0; counter--)
            {
                reversedString.Append(pInputeValue[counter]);
            }

            return reversedString.ToString();
        }

        public static string ReverseWords(string pInputeValue)
        {
            if (string.IsNullOrEmpty(pInputeValue))
            {
                return "";
            }

            StringBuilder reversedString = new();
            var split = pInputeValue.Split(' ');

            for (int counter = split.Length - 1; counter >= 0; counter--)
            {
                reversedString.Append(split[counter]);

                if (counter > 0)
                {
                    reversedString.Append(' ');
                }
            }

            return reversedString.ToString();
        }

        private static string CountVowelsAndConsonantsRev(string pInputvalue)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            char[] consonants =
            [
                'b', 'c', 'd', 'f', 'g',
                'h', 'j', 'k', 'l', 'm',
                'n', 'p', 'q', 'r', 's',
                't', 'v', 'w', 'x', 'y',
                'z'
            ];

            if (string.IsNullOrEmpty(pInputvalue))
            {
                return "Value was empty";
            }

            int vowelsCounter = 0;
            int consantsCounter = 0;

            pInputvalue = pInputvalue.ToLower();

            foreach (char character in pInputvalue)
            {
                if (vowels.Contains(character))
                {
                    vowelsCounter++;
                }
                else if (consonants.Contains(character))
                {
                    consantsCounter++;
                }
            }

            return $"Total Vowels: {vowelsCounter} || Total Consonants: {consantsCounter}";

        }

        public static int[] RemoveLastOccurrenceRevision(int[] pInputValue, int pTarget)
        {

            if (pInputValue == null || pInputValue.Length == 0)
            {
                return [];
            }

            List<int> newList = [];
            int lastIndex = -1;

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (pInputValue[counter] == pTarget)
                {
                    lastIndex = counter;
                }
            }

            for (int counter = 0; counter <= pInputValue.Length - 1; counter++)
            {
                if (counter != lastIndex)
                {
                    newList.Add(pInputValue[counter]);
                }
            }

            return newList.ToArray();
        }

        public static string CountUpperCaseLetters(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "String is empty";
            }

            int counter = 0;

            foreach (char character in pInputValue)
            {
                if (char.IsUpper(character))
                {
                    counter++;
                }
            }

            return $"Total upper case letters for {pInputValue} is: {counter}";
        }

        public static string CapitaliseFirstLetter(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "String is empty";
            }

            char capitalLetter = char.ToUpper(pInputValue[0]);
            string newString = capitalLetter + pInputValue.Substring(1);

            return newString;
        }

        public static int CountWordsFriday(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return -1;
            }

            bool isInsideWord = true;
            int wordCount = 0;

            foreach (char character in pInputValue)
            {
                if (!char.IsWhiteSpace(character))
                {
                    if (isInsideWord == true)
                    {
                        wordCount++;
                        isInsideWord = false;
                    }
                }
                else
                {
                    isInsideWord = true;
                }
            }

            return wordCount;
        }

        public static string CapitaliseEachWord(string pInputVale)
        {
            if (string.IsNullOrEmpty(pInputVale))
            {
                return "String is empty";
            }

            var split = pInputVale.Split(" ");
            StringBuilder newString = new();

            foreach (string character in split)
            {
                char characterHolder = character[0];
                characterHolder = char.ToUpper(characterHolder);

                newString.Append(characterHolder).Append(character.Substring(1));
                newString.Append(' ');
            }

            return newString.ToString().Trim();
        }


        public void RunAllChallengeSolutions()
        {

            // Find the longest word
            // - Return the length of the longest word in a string 
            // - Example: Cyberpunk card vault => 9 for Cyberpunk
            Console.WriteLine(FindLongestWordLength("Cyberpunk card vault") == 9); // 9
            Console.WriteLine(FindLongestWordLength("dog cat mouse") == 5); // 5
            Console.WriteLine(FindLongestWordLength("hello") == 5); // 5
            Console.WriteLine(FindLongestWordLength("") == 0); // 0
            Console.WriteLine(FindLongestWordLength("a ab abc abcd") == 4); //4

            // Is Palindrome ignoring spaces
            // - Return true if the string is a palinfrome while ignoring spaces
            // -- racecar  = true || race car == True
            // --- hello ==> false 
            // ---- Return false for null or empty 
            // Console.WriteLine(IsPalindromeIgnoringSpaces("racecar") == true);
            // Console.WriteLine(IsPalindromeIgnoringSpaces("race car") == true);
            // Console.WriteLine(IsPalindromeIgnoringSpaces("never odd or even") == true);
            // Console.WriteLine(IsPalindromeIgnoringSpaces("hello") == false);
            // Console.WriteLine(IsPalindromeIgnoringSpaces("") == false);
            // Console.WriteLine(IsPalindromeIgnoringSpaces(null) == false);


            // Count Lower Case Letters
            // Console.WriteLine(CountLowerCaseLetters("hello") == 5);
            // Console.WriteLine(CountLowerCaseLetters("Hello World") == 8);
            // Console.WriteLine(CountLowerCaseLetters("ABC") == 0);
            // Console.WriteLine(CountLowerCaseLetters("aBc123!") == 2);
            // Console.WriteLine(CountLowerCaseLetters("") == 0);


            // Count Words Revision
            // - Return how many words are in the a string 
            // - isInsider Word
            // Console.WriteLine(CountWords("Hello World") == 2);
            // Console.WriteLine(CountWords("One Two Three Four") == 4);
            // Console.WriteLine(CountWords("Cyberpunk") == 1);
            // Console.WriteLine(CountWords("") == 0);
            // Console.WriteLine(CountWords("   ") == 0);
            // Console.WriteLine(CountWords("  Hello   World  ") == 2);

            // COunt Vowels and Consonants 
            // -Return a string showing vowels and consonants 
            // Console.WriteLine(CountVowelsAndConsonants("hello") == "Vowels: 2, Consonants: 3");
            // Console.WriteLine(CountVowelsAndConsonants("aeiou") == "Vowels: 5, Consonants: 0");
            // Console.WriteLine(CountVowelsAndConsonants("bcdfg") == "Vowels: 0, Consonants: 5");
            // Console.WriteLine(CountVowelsAndConsonants("A1B2C3") == "Vowels: 1, Consonants: 2");
            // Console.WriteLine(CountVowelsAndConsonants("") == "Vowels: 0, Consonants: 0");


            // Remove vowels From a string
            //- return a string with all vowels removed
            // Console.WriteLine(RemoveVowels("hello") == "hll");
            // Console.WriteLine(RemoveVowels("AEIOU") == "");
            // Console.WriteLine(RemoveVowels("Cyberpunk") == "cybrpnk");
            // Console.WriteLine(RemoveVowels("Programming") == "prgrmmng");
            // Console.WriteLine(RemoveVowels("") == "");


            // Capitalise Each Word == "Hello World" -- String
            //Console.WriteLine(CapitaliseEachWord("hello world"));               // Hello World
            //Console.WriteLine(CapitaliseEachWord("c# is awesome"));             // C# Is Awesome
            //Console.WriteLine(CapitaliseEachWord("one two three four"));        // One Two Three Four
            //Console.WriteLine(CapitaliseEachWord("hello"));                     // Hello
            //Console.WriteLine(CapitaliseEachWord(""));                          // (empty)
            // Console.WriteLine(CountUpperCaseLetters("123!@#"));     // 0
            // Console.WriteLine(CountWords("   "));                   // edge case
            // Console.WriteLine(CapitaliseFirstLetter("a"));          // A
            // Console.WriteLine(CapitaliseEachWord("a b c"));         // A B C
            // Console.WriteLine(CountVowelsAndConsonants("WHY"));     // Vowels: 0, Consonants: 3


            // Capitalise First Letter === Return the same string but with the first character uppercase
            // Console.WriteLine(CapitaliseFirstLetter("hello"));          // Hello
            // Console.WriteLine(CapitaliseFirstLetter("world"));          // World
            // Console.WriteLine(CapitaliseFirstLetter("hello world"));    // Hello world
            // Console.WriteLine(CapitaliseFirstLetter("Hello"));          // Hello
            // Console.WriteLine(CapitaliseFirstLetter(""));               // (empty)






            // Count UpperCase Letters -- string - return string 
            // Console.WriteLine(CountUpperCaseLetters("Hello World"));     // 2
            // Console.WriteLine(CountUpperCaseLetters("HELLO"));           // 5
            // Console.WriteLine(CountUpperCaseLetters("hello"));           // 0
            // Console.WriteLine(CountUpperCaseLetters("HeLLo WoRLD"));     // 7
            // Console.WriteLine(CountUpperCaseLetters(""));                // 0


            // Count Words, -- IsInsider word? String 
            // Console.WriteLine(CountWords("Hello World"));                    // 2
            // Console.WriteLine(CountWords("One Two Three Four"));             // 4
            // Console.WriteLine(CountWords("Single"));                         // 1
            // Console.WriteLine(CountWords(""));                               // 0
            // Console.WriteLine(CountWords("C# is fun"));                      // 3

            // Remove last Occurrence Revision --  array with target - [1, 5, 10, 5] - target 5 = [1,5,10]
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([1, 5, 10, 5], 5))); // 1,5,10
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([5, 1, 5, 5], 5)));  // 5,1,5
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([1, 2, 3], 9)));     // 1,2,3
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([5], 5)));           // (empty)
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevision([5, 5, 5], 5)));     // 5,5



            // Count Vowels and Consonants Revision  -- Case Insenseitivity - Treay y as a consant
            // Console.WriteLine(CountVowelsAndConsonants("Hello"));       // Vowels: 2, Consonants: 3
            // Console.WriteLine(CountVowelsAndConsonants("AEIOU"));       // Vowels: 5, Consonants: 0
            // Console.WriteLine(CountVowelsAndConsonants("xyz"));         // Vowels: 0, Consonants: 3
            // Console.WriteLine(CountVowelsAndConsonants("Seagate"));     // Vowels: 4, Consonants: 3
            // Console.WriteLine(CountVowelsAndConsonants(""));            // Vowels: 0, Consonants: 0



            /*
          Best target next session
          Minimum:
          1. Count Uppercase Letters
          2. Remove Last Occurrence revision
          3. Count Vowels and Consonants revision

          Good:
          4. Count Words
          5. Capitalize First Letter

          Stretch:
          6. Capitalize Each Word         
       */

            // Refactor Later:


            // Count Odd Numbers 
            // Console.WriteLine(CountOddNumbersRevisionOne([1, 2, 3, 4, 5])); // 3
            // Console.WriteLine(CountOddNumbersRevisionOne([2, 4, 6, 8]));    // 0
            // Console.WriteLine(CountOddNumbersRevisionOne([1, 3, 5, 7]));    // 4
            // Console.WriteLine(CountOddNumbersRevisionOne([]));               // 0

            // Most Frequent Number Revision

            // Console.WriteLine(MostFrequentNumberRevisionOne([1, 2, 2, 3, 2])); // 2
            // Console.WriteLine(MostFrequentNumberRevisionOne([5, 5, 1, 1, 5])); // 5
            // Console.WriteLine(MostFrequentNumberRevisionOne([9]));             // 9
            // Console.WriteLine(MostFrequentNumberRevisionOne([7, 7, 7, 7]));   // 7

            // Remove last occurrence - [1,5,10, 5] Target 5 => [1,5, 10] 
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 1, 5, 10, 5 }, 5))); // 1,5,10
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 5, 1, 5, 5 }, 5)));  // 5,1,5
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceRevisionOne(new int[] { 5 }, 5)));           // (empty)


            // Count Vowels and Consants
            // CountVowelsAndConsonantsRevisionOne("hello");      // Vowels: 2, Consonants: 3
            // CountVowelsAndConsonantsRevisionOne("AEIOU");      // Vowels: 5, Consonants: 0
            // CountVowelsAndConsonantsRevisionOne("bcdfg");      // Vowels: 0, Consonants: 5
            // CountVowelsAndConsonantsRevisionOne("Hello World"); // Vowels: 3, Consonants: 7


            // Remove spaces From String 
            // Console.WriteLine(RemoveSpaces("Hello World"));          // HelloWorld
            // Console.WriteLine(RemoveSpaces(" C# Is Fun "));          // C#IsFun
            // Console.WriteLine(RemoveSpaces("NoSpaces"));             // NoSpaces
            // Console.WriteLine(RemoveSpaces("   "));                  // (empty)

            // Reverse Words in string
            // Console.WriteLine(ReverseString("Hello World"));                 // World Hello
            // Console.WriteLine(ReverseString("C# Is Awesome"));               // Awesome Is C#
            // Console.WriteLine(ReverseString("One Two Three Four"));          // Four Three Two One
            // Console.WriteLine(ReverseString("Single"));                      // Single

            // // Reverse Words in Sentence
            // Console.WriteLine(ReverseWords("Hello World"));                 // World Hello
            // Console.WriteLine(ReverseWords("C# Is Awesome"));               // Awesome Is C#
            // Console.WriteLine(ReverseWords("One Two Three Four"));          // Four Three Two One
            // Console.WriteLine(ReverseWords("Single"));                      // Single

            // 1. Count even numbers (Sum)
            Console.WriteLine(SumEvenNumbersRev([1, 2, 3, 4, 5, 6])); // 12 (2+4+6)
            Console.WriteLine(SumEvenNumbersRev([2, 4, 6, 8]));       // 20
            Console.WriteLine(SumEvenNumbersRev([1, 3, 5]));          // 0
            Console.WriteLine(SumEvenNumbersRev([]));                  // 0


            //  2. Replace target with value 
            //- Replace every number that matches the target with a new replacement value 
            //- Example [1,5,10,5] - Target 5, replacement 99 == [1,99,10,99]
            Console.WriteLine(string.Join(",", ReplaceTarget([1, 5, 10, 5], 5, 99))); // 1,99,10,99
            Console.WriteLine(string.Join(",", ReplaceTarget([5, 5, 5], 5, 0)));      // 0,0,0
            Console.WriteLine(string.Join(",", ReplaceTarget([1, 2, 3], 9, 100)));    // 1,2,3

            // 3. Split positive and negative numbers: 
            // - Return a new array with positive numbers first, then negative numbers, ignore zeros completely
            Console.WriteLine(string.Join(",", SplitPosNeg([1, -2, 3, -4, 0]))); // 1,3,-2,-4
            Console.WriteLine(string.Join(",", SplitPosNeg([-1, -2, -3])));      // -1,-2,-3
            Console.WriteLine(string.Join(",", SplitPosNeg([1, 2, 3])));         // 1,2,3
            Console.WriteLine(string.Join(",", SplitPosNeg([0, 0, 0])));         // (empty)

            // 4. Count Matching Numbers
            // -Count how many times a target number appears in an array
            Console.WriteLine(CountMatching([1, 2, 2, 3, 2], 2)); // 3
            Console.WriteLine(CountMatching([5, 5, 5, 5], 5));    // 4
            Console.WriteLine(CountMatching([1, 2, 3], 9));       // 0

            // 5. Remove Target  From array
            // - Remove every number that matches target 
            // - Return a new array with all matching target values matched 
            Console.WriteLine(string.Join(",", RemoveTarget([1, 2, 3, 2, 4], 2))); // 1,3,4
            Console.WriteLine(string.Join(",", RemoveTarget([5, 5, 5], 5)));       // (empty)
            Console.WriteLine(string.Join(",", RemoveTarget([1, 2, 3], 9)));       // 1,2,3


            // 6. Move Target to the end 
            // - meaning move every matching target value to the end of the array.kepp non-target numbers
            // - in the original order. 
            // Return  a new array where all target values are moved to the end
            Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3, 2, 4], 2))); // 1,3,4,2,2
            Console.WriteLine(string.Join(",", MoveTargetToEnd([5, 1, 5, 2], 5)));    // 1,2,5,5
            Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3], 9)));       // 1,2,3
            // New Challenge: Replace Target With Value
            Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 99 should return [1, 99, 5, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 0, 5, 0], 0, 99))}]");
            Console.WriteLine($"[1, 0, 5, 0], target 0, replacement 0 should return [1, 0, 5, 0] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 0, 5, 0], 0, 0))}]");
            Console.WriteLine($"[1, 5, 10, 5], target 5, replacement 99 should return [1, 99, 10, 99] => Answer: [{string.Join(", ", ReplaceTargetWithValue([1, 5, 10, 5], 5, 99))}]");
            Console.WriteLine($"[3, 4, 5], target 9, replacement 0 should return [3, 4, 5] => Answer: [{string.Join(", ", ReplaceTargetWithValue([3, 4, 5], 9, 0))}]");
            Console.WriteLine($"[7], target 7, replacement 1 should return [1] => Answer: [{string.Join(", ", ReplaceTargetWithValue([7], 7, 1))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue([], 5, 99))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", ReplaceTargetWithValue(null!, 5, 99))}]");


            //  Split Positive And Negative Numbers
            // Return a new array with positive numbers first, then negative numbers. Ignore zero.
            Console.WriteLine($"[1, -2, 3, -4, 0] should return [1, 3, -2, -4] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([1, -2, 3, -4, 0]))}]");
            Console.WriteLine($"[-1, -2, 5] should return [5, -1, -2] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([-1, -2, 5]))}]");
            Console.WriteLine($"[0, 0] should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([0, 0]))}]");
            Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([1, 2, 3]))}]");
            Console.WriteLine($"[-1, -2, -3] should return [-1, -2, -3] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([-1, -2, -3]))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers([]))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", SplitPositiveAndNegativeNumbers(null!))}]");


            // Count Numbers Less Than Target
            //Console.WriteLine(CountNumbersLessThanTarget([1, 5, 10, 3], 4));
            //Console.WriteLine(CountNumbersLessThanTarget([10, 20, 30], 15));
            //Console.WriteLine(CountNumbersLessThanTarget([-5, -2, 0], 1));
            //Console.WriteLine(CountNumbersLessThanTarget([1, 2, 3], 0));
            //Console.WriteLine(CountNumbersLessThanTarget([], 4));
            //Console.WriteLine(CountNumbersLessThanTarget(null!, 4));

            // Sum Positive Numbers
            Console.WriteLine(SumPositiveNumbersRev2([1, 2, 4]));
            Console.WriteLine(SumPositiveNumbersRev2([0, 0, 0, 5]));
            Console.WriteLine(SumPositiveNumbersRev2([-1, -2, -3, 5]));
            Console.WriteLine(SumPositiveNumbersRev2([1]));
            Console.WriteLine(SumPositiveNumbersRev2([]));
            Console.WriteLine(SumPositiveNumbersRev2(null!));

            // Merge Arrays(Duplicates allowed)
            Console.WriteLine($"[1, 2], [3, 4] should return [1, 2, 3, 4] => Answer: [{string.Join(", ", MergeArrays([1, 2], [3, 4]))}]");
            Console.WriteLine($"[1, 2], [2, 3] should return [1, 2, 2, 3] => Answer: [{string.Join(", ", MergeArrays([1, 2], [2, 3]))}]");
            Console.WriteLine($"[], [1, 2] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([], [1, 2]))}]");
            Console.WriteLine($"[1, 2], [] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([1, 2], []))}]");
            Console.WriteLine($"null, [1, 2] should return [1, 2] => Answer: [{string.Join(", ", MergeArrays(null!, [1, 2]))}]");
            Console.WriteLine($"[1, 2], null should return [1, 2] => Answer: [{string.Join(", ", MergeArrays([1, 2], null!))}]");
            Console.WriteLine($"null, null should return [] => Answer: [{string.Join(", ", MergeArrays(null!, null!))}]");
            Console.WriteLine($"[], [] should return [] => Answer: [{string.Join(", ", MergeArrays([], []))}]");


            // Find Last Index of Target
            Console.WriteLine($"[1, 5, 10, 5], target 5 should return 3 => Answer: {FindLastIndexOfTarget([1, 5, 10, 5], 5)}");
            Console.WriteLine($"[3, 4, 5], target 9 should return -1 => Answer: {FindLastIndexOfTarget([3, 4, 5], 9)}");
            Console.WriteLine($"[7], target 7 should return 0 => Answer: {FindLastIndexOfTarget([7], 7)}");
            Console.WriteLine($"[5, 5, 5], target 5 should return 2 => Answer: {FindLastIndexOfTarget([5, 5, 5], 5)}");
            Console.WriteLine($"Empty array, target 1 should return -1 => Answer: {FindLastIndexOfTarget([], 1)}");
            Console.WriteLine($"Null, target 1 should return -1 => Answer: {FindLastIndexOfTarget(null!, 1)}");
            // Remove Duplicate numbers:
            Console.WriteLine($"[1, 2, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([1, 2, 2, 3]))}]");
            Console.WriteLine($"[5, 5, 5] should return [5] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([5, 5, 5]))}]");
            Console.WriteLine($"[1, 2, 3] should return [1, 2, 3] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([1, 2, 3]))}]");
            Console.WriteLine($"[4, 1, 4, 2, 1] should return [4, 1, 2] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([4, 1, 4, 2, 1]))}]");
            Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers([]))}]");
            Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", RemoveDuplicateNumbers(null!))}]");


            // Find missing number: You are given numbers from 1 to n, but one number is missing.
            Console.WriteLine($"[1, 2, 4, 5] should return 3 => Answer: {FindMissingNumber([1, 2, 4, 5])}");
            Console.WriteLine($"[1, 3, 4, 5] should return 2 => Answer: {FindMissingNumber([1, 3, 4, 5])}");
            Console.WriteLine($"[2, 3, 4, 5] should return 1 => Answer: {FindMissingNumber([2, 3, 4, 5])}");
            Console.WriteLine($"[1, 2, 3, 4] should return 5 => Answer: {FindMissingNumber([1, 2, 3, 4])}");
            Console.WriteLine($"[1, 2, 3, 5, 6] should return 4 => Answer: {FindMissingNumber([1, 2, 3, 5, 6])}");
            Console.WriteLine($"Empty array should return 0 => Answer: {FindMissingNumber([])}");
            Console.WriteLine($"Null should return 0 => Answer: {FindMissingNumber(null!)}");

            // Two Sum Revision:
            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision([2, 7, 11, 15], 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision([4, 5], 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRevision([3, 2, 4], 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRevision([3, 3], 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRevision([1, 8, 10, 2], 10))}]");


            //// Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacterRev("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacterRev("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacterRev("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacterRev("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacterRev("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacterRev(null!)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacterRev("Cyberpunk")}");

            //// Count Negative Numbers: 
            Console.WriteLine(CountNegativeNumbers([1, -2, 3, -4, 5]));
            Console.WriteLine(CountNegativeNumbers([-1, -2, -3]));
            Console.WriteLine(CountNegativeNumbers([0, 0, 0]));
            Console.WriteLine(CountNegativeNumbers([10]));
            Console.WriteLine(CountNegativeNumbers([]));
            Console.WriteLine(CountNegativeNumbers(null!));

            // Find first Non Repeating Character:
            Console.WriteLine($"swiss should return w => Answer: {FindFirstNonRepeatingCharacter("swiss")}");
            Console.WriteLine($"hello should return h => Answer: {FindFirstNonRepeatingCharacter("hello")}");
            Console.WriteLine($"aabbc should return c => Answer: {FindFirstNonRepeatingCharacter("aabbc")}");
            Console.WriteLine($"aabb should return _ => Answer: {FindFirstNonRepeatingCharacter("aabb")}");
            Console.WriteLine($"Empty string should return _ => Answer: {FindFirstNonRepeatingCharacter("")}");
            Console.WriteLine($"Null should return _ => Answer: {FindFirstNonRepeatingCharacter(null!)}");
            Console.WriteLine($"Cyberpunk should return C or c depending on casing rule => Answer: {FindFirstNonRepeatingCharacter("Cyberpunk")}");

            // Find First Repeated Numbers
            Console.WriteLine($"[1, 2, 3, 2] should return 2 => Answer: {FindFirstRepeatedNumber([1, 2, 3, 2])}");
            Console.WriteLine($"[5, 1, 5, 2] should return 5 => Answer: {FindFirstRepeatedNumber([5, 1, 5, 2])}");
            Console.WriteLine($"[4, 4, 4] should return 4 => Answer: {FindFirstRepeatedNumber([4, 4, 4])}");
            Console.WriteLine($"[1, 2, 3] should return 0 => Answer: {FindFirstRepeatedNumber([1, 2, 3])}");
            Console.WriteLine($"Empty array should return 0 => Answer: {FindFirstRepeatedNumber([])}");
            Console.WriteLine($"Null should return 0 => Answer: {FindFirstRepeatedNumber(null!)}");

            // Count Positive Numbers
            Console.WriteLine(CountPositiveNumbers([1, -2, 3, 0, 5]));
            Console.WriteLine(CountPositiveNumbers([-1, -2, -3]));
            Console.WriteLine(CountPositiveNumbers([0, 0, 0]));
            Console.WriteLine(CountPositiveNumbers([10]));
            Console.WriteLine(CountPositiveNumbers(null!));
            Console.WriteLine(CountPositiveNumbers([]));

            // TwoSumRev
            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev([2, 7, 11, 15], 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev([4, 5], 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSumRev([3, 2, 4], 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSumRev([3, 3], 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSumRev([1, 8, 10, 2], 10))}]");

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
            Console.WriteLine($"Null should be vowels: 0, consonants: 0 => Answer: {CountVowelsAndConsonants(null!)}");
            Console.WriteLine($"Why should be vowels: 0, consonants: 3 => Answer: {CountVowelsAndConsonants("Why")}");

            // Counting Character Occurrences
            // Create a method that takes a string and a character, then returns how many times that character appears.
            Console.WriteLine(CharacterOccurrences("hello", 'l'));
            Console.WriteLine(CharacterOccurrences("Cyberpunk", 'y'));
            Console.WriteLine(CharacterOccurrences("APPLE", 'p'));
            Console.WriteLine(CharacterOccurrences("aaaa", 'a'));
            Console.WriteLine(CharacterOccurrences("", 'a'));
            Console.WriteLine(CharacterOccurrences("null", 'a'));

            Console.WriteLine($"TwoSum [2, 7, 11, 15], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSum([2, 7, 11, 15], 9))}]");
            Console.WriteLine($"TwoSum [4, 5], target 9 should be [0, 1] => Answer: [{string.Join(", ", TwoSum([4, 5], 9))}]");
            Console.WriteLine($"TwoSum [3, 2, 4], target 6 should be [1, 2] => Answer: [{string.Join(", ", TwoSum([3, 2, 4], 6))}]");
            Console.WriteLine($"TwoSum [3, 3], target 6 should be [0, 1] => Answer: [{string.Join(", ", TwoSum([3, 3], 6))}]");
            Console.WriteLine($"TwoSum [1, 8, 10, 2], target 10 should be [1, 3] => Answer: [{string.Join(", ", TwoSum([1, 8, 10, 2], 10))}]");

            // IsArray Ascending - Return True if the array is sorted From Smallest to Largest: 
            Console.WriteLine(IsSortedArrayAscending([1, 2, 3, 4]));
            // Expected: True
            Console.WriteLine(IsSortedArrayAscending([1, 1, 2, 3]));
            // Expected: True (duplicates allowed)
            Console.WriteLine(IsSortedArrayAscending([1, 3, 2, 4]));
            // Expected: False
            Console.WriteLine(IsSortedArrayAscending([5, 4, 3, 2]));
            // Expected: False
            Console.WriteLine(IsSortedArrayAscending([10]));
            // Expected: True (single element)
            Console.WriteLine(IsSortedArrayAscending([]));
            // Expected: True (empty array)
            Console.WriteLine(IsSortedArrayAscending([2, 2, 2, 2]));
            // Expected: True
            Console.WriteLine(IsSortedArrayAscending(null!));
            // Expected: false (empty array)

            // Find Second Largest Number
            Console.WriteLine(FindTheSecondLargestNumber([1, 2, 4, 5])); // 3
            Console.WriteLine(FindTheSecondLargestNumber([1, 3, 4, 5])); // 2
            Console.WriteLine(FindTheSecondLargestNumber([2, 3, 4, 5])); // 1
            Console.WriteLine(FindTheSecondLargestNumber([1, 2, 3, 4])); // 5
            Console.WriteLine(FindTheSecondLargestNumber([])); // 0
            Console.WriteLine(FindTheSecondLargestNumber(null!)); // 0

            // Find Missing Number: 
            Console.WriteLine(FindMissingNumber([1, 2, 4, 5])); // 3
            Console.WriteLine(FindMissingNumber([1, 3, 4, 5])); // 2
            Console.WriteLine(FindMissingNumber([2, 3, 4, 5])); // 1
            Console.WriteLine(FindMissingNumber([1, 2, 3, 4])); // 5
            Console.WriteLine(FindMissingNumber([])); // 0
            Console.WriteLine(FindMissingNumber(null!)); // 0

            // Sum Positive Numbers 
            // - Return total numbers greater than 0

            Console.WriteLine(SumPositiveNumbers([1, 2, 4])); // 3
            Console.WriteLine(SumPositiveNumbers([0, 0, 0, 5])); // 1 
            Console.WriteLine(SumPositiveNumbers([-1, -2, -3, 5])); // 1
            Console.WriteLine(SumPositiveNumbers([1])); // 1
            Console.WriteLine(SumPositiveNumbers([])); // 0
            Console.WriteLine(SumPositiveNumbers(null!)); // 0

            // Find Second Largest number:             
            Console.WriteLine(CountSecondLargestNumberRev([-1, 6, 3, 9, 2]));
            Console.WriteLine(CountSecondLargestNumberRev([10, 20, 30,]));
            Console.WriteLine(CountSecondLargestNumberRev([30, 20, 10]));
            Console.WriteLine(CountSecondLargestNumberRev([0 - 5, -2, -1, -10]));
            Console.WriteLine(CountSecondLargestNumberRev([]));
            Console.WriteLine(CountSecondLargestNumberRev(null!));

            // Merged Arrays: Return a new array  containing all numbers from the 1st 
            /// array followed by all the numbers from the second Array

            Console.WriteLine(string.Join(",", MergeArraysRev([1, 2, 3], [4, 5, 6]))); // Expected: 1,2,3,4,5,6
            Console.WriteLine(string.Join(",", MergeArraysRev([], [1, 2]))); // Expected: 1,2
            Console.WriteLine(string.Join(",", MergeArraysRev([7, 8], []))); // Expected: 7,8
            Console.WriteLine(string.Join(",", MergeArraysRev([-1, -2], [0, 1]))); // Expected: -1,-2,0,1
            Console.WriteLine(string.Join(",", MergeArraysRev([], []))); // Expected: -1,-2,0,1

            // Find index of Target:  Return the index of the first number
            // - matching the target. Return -1 if not found. 
            // - [1,5,10], target 5 = index would be 1
            Console.WriteLine(FindIndexOfTarget(null!, 5));      // -1 (null array)
            Console.WriteLine(FindIndexOfTarget([], 5));        // -1 (empty array)
            Console.WriteLine(FindIndexOfTarget([1, 2, 3], 2)); // 1 (found at index 1)
            Console.WriteLine(FindIndexOfTarget([1, 2, 3], 4)); // -1 (not found)
            Console.WriteLine(FindIndexOfTarget([5, 5, 5], 5)); // 0 (first match returned)
            Console.WriteLine(FindIndexOfTarget([9], 9));       // 0 (single element match)
            Console.WriteLine(FindIndexOfTarget([9], 1));       // -1 (single element no match)

            // Console.WriteLine(CountNumbersInRange(null, 1, 5));              // 0 (null array)
            Console.WriteLine(CountNumbersInRange(Array.Empty<int>(), 1, 5));   // 0 (empty array)
            Console.WriteLine(CountNumbersInRange([1, 5, 10, 15], 5, 10));      // 2 (5 and 10)
            Console.WriteLine(CountNumbersInRange([3, 6, 9], 1, 5));            // 1 (3)
            Console.WriteLine(CountNumbersInRange([2, 4, 6, 8], 4, 8));         // 3 (4,6,8)
            Console.WriteLine(CountNumbersInRange([10, 20, 30], 5, 9));         // 0 (none in range)
            Console.WriteLine(CountNumbersInRange([5, 5, 5], 5, 5));            // 3 (all match)
            Console.WriteLine(CountNumbersInRange([-5, 0, 5], -5, 0));      // 2 (-5, 0)


            // Filter Numbers between Range: 
            // - Return a new array containing only numbers between
            // - min and max
            // - Example: [1,5,10, 15] - min: 5 max 10 = [5, 10]
            // - Example [3,6,9] min 1, max 5 = 1 [3]
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange(null!, 1, 5)));            // Blank
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([], 1, 5)));              // Blank 
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([1, 5, 10, 15], 5, 10))); // 5, 10
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([3, 6, 9], 1, 5)));       // 3
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([2, 4, 6, 8], 4, 8)));    // 4, 6, 8
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([10, 20, 30], 1, 5)));    // Blank
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([5, 5, 5], 5, 5)));       // 5, 5, 5
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([-5, 0, 5], -5, 0)));     // -5, 0
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([1, 2, 3, 4, 5], 2, 4))); // 2, 3, 4
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([7], 7, 7)));             // 7
            Console.WriteLine(string.Join(", ", FilterNumbersBetweenRange([7], 1, 5)));             // Blank

            // 1. Count Non-Zero Numbers
            // - Return how many numbers are not zero

            // Console.WriteLine(CountNonZero([1, 0, 2, 0, 3])); // 3
            // Console.WriteLine(CountNonZero([0, 0, 0]));       // 0
            // Console.WriteLine(CountNonZero([1, 2, 3]));       // 3
            // Console.WriteLine(CountNonZero([]));               // 0

            // 2. Revision: Move Target to End 
            // - Move Target values within an array to the end of the array
            // Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3, 2, 4], 2))); // 1,3,4,2,2
            // Console.WriteLine(string.Join(",", MoveTargetToEnd([5, 1, 5, 2], 5)));    // 1,2,5,5
            // Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3], 9)));       // 1,2,3

            // 3. Revision: Find Second Largest Number 
            // Console.WriteLine(FindSecondLargestNumRev([1, 2, 3, 4]));     // 3
            // Console.WriteLine(FindSecondLargestNumRev([10, 5, 8, 20]));   // 10
            // Console.WriteLine(FindSecondLargestNumRev([5, 5, 5, 5]));     // 5
            // Console.WriteLine(FindSecondLargestNumRev([1]));              // 1


            // 4. New Challenge Find Most Frequent Number
            // - Return the number that appears the most 
            // 
            // Console.WriteLine(MostFrequentNumberInArray([1, 2, 2, 3, 2])); // 2
            // Console.WriteLine(MostFrequentNumberInArray([5, 5, 1, 1]));    // 5
            // Console.WriteLine(MostFrequentNumberInArray([9]));             // 9
            // Console.WriteLine(MostFrequentNumberInArray([]));               // 0


            // 5. New Challenge: Rotating Array Right By One
            // Move the Last number to the front - New Sized array 
            // Example [1,2,3,4] -> [4,1,2,3]
            // [10, 20, 30] -> [30, 10, 20]
            // Put last value at index 0; Then
            // copy the rest of the orginal values one positon to 
            // the right
            // Console.WriteLine(string.Join(",", RotateArrayRight(new int[] { 1, 2, 3, 4 }))); // 4,1,2,3
            // Console.WriteLine(string.Join(",", RotateArrayRight(new int[] { 10, 20, 30 }))); // 30,10,20
            // Console.WriteLine(string.Join(",", RotateArrayRight(new int[] { 1 })));          // 1
            // Console.WriteLine(string.Join(",", RotateArrayRight(new int[] { })));            // (empty)

            // 6. New Challenge(Optional): Rotate Array Left By One 
            // -Move the first number to the end
            // Example: [1,2,3,4,] = [2,3,4,1]
            // Copy Everything after index 0 one position left.
            // Put the original 1st value at the end
            Console.WriteLine(string.Join(",", RotateArrayLeftRev([1, 2, 3, 4]))); // 2,3,4,1
            Console.WriteLine(string.Join(",", RotateArrayLeftRev([10, 20, 30]))); // 20,30,10
            Console.WriteLine(string.Join(",", RotateArrayLeft([1])));          // 1
            Console.WriteLine(string.Join(",", RotateArrayLeft([])));            // (empty)

            // 1. Count Non-Zero Numbers - Complete
            // - Return how many numbers are not zero

            // Console.WriteLine(CountNonZero([1, 0, 2, 0, 3])); // 3
            // Console.WriteLine(CountNonZero([0, 0, 0]));       // 0
            // Console.WriteLine(CountNonZero([1, 2, 3]));       // 3
            // Console.WriteLine(CountNonZero([]));               // 0

            // 2. Revision: Move Target to End 
            // - Move Target values within an array to the end of the array
            // Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3, 2, 4], 2))); // 1,3,4,2,2
            // Console.WriteLine(string.Join(",", MoveTargetToEnd([5, 1, 5, 2], 5)));    // 1,2,5,5
            // Console.WriteLine(string.Join(",", MoveTargetToEnd([1, 2, 3], 9)));       // 1,2,3

            // 3. Revision: Find Second Largest Number 
            Console.WriteLine(FindSecondLargestNumberRevTwo([1, 2, 3, 4]));     // 3
            Console.WriteLine(FindSecondLargestNumberRevTwo([10, 5, 8, 20]));   // 10
            Console.WriteLine(FindSecondLargestNumberRevTwo([5, 5, 5, 5]));     // 5
            Console.WriteLine(FindSecondLargestNumberRevTwo([1]));              // 1
            Console.WriteLine(FindSecondLargestNumberRevTwo([5, 10])); // 5
            Console.WriteLine(FindSecondLargestNumberRevTwo([7, 7, 7, 7]));
            Console.WriteLine(FindSecondLargestNumberRevTwo([-10, -5, -20, -1])); // -5
            Console.WriteLine(FindSecondLargestNumberRevTwo([-10, 5, 3, 2])); // 3
            Console.WriteLine(FindSecondLargestNumberRevTwo([10, 10, 5, 3])); // 5
            Console.WriteLine(FindSecondLargestNumberRevTwo([]));



            // 4. New Challenge Find Most Frequent Number
            // - Return the number that appears the most 
            // 
            // Console.WriteLine(MostFrequentNumberInArray([1, 2, 2, 3, 2])); // 2
            // Console.WriteLine(MostFrequentNumberInArray([5, 5, 1, 1]));    // 5
            // Console.WriteLine(MostFrequentNumberInArray([9]));             // 9
            // Console.WriteLine(MostFrequentNumberInArray([]));               // 0


            // 5. New Challenge: Rotating Array Right By One - Complete
            // Move the Last number to the front - New Sized array 
            // Example [1,2,3,4] -> [4,1,2,3]
            // [10, 20, 30] -> [30, 10, 20]
            // Put last value at index 0; Then
            // copy the rest of the orginal values one positon to 
            // the right
            // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { 1, 2, 3, 4 }))); // 4,1,2,3
            // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { 10, 20, 30 }))); // 30,10,20
            // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { 1 })));          // 1
            // Console.WriteLine(string.Join(",", RotateArrayToRight(new int[] { })));            // (empty)

            // 6. New Challenge(Optional): Rotate Array Left By One 
            // -Move the first number to the end
            // Example: [1,2,3,4,] = [2,3,4,1]
            // Copy Everything after index 0 one position left.
            // Put the original 1st value at the end
            // Console.WriteLine(string.Join(",", RotateArrayLeft([1, 2, 3, 4]))); // 2,3,4,1
            // Console.WriteLine(string.Join(",", RotateArrayLeft([10, 20, 30]))); // 20,30,10
            // Console.WriteLine(string.Join(",", RotateArrayLeft([1])));          // 1
            // Console.WriteLine(string.Join(",", RotateArrayLeft([])));            // (empty)

            // 7 Remove First occurrence of target:
            // - Remove only the first matching target Value. 
            // Example: [1,5,10,5] Target: 5 => [1,10,5]
            // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 1, 5, 10, 5 }, 5))); // 1,10,5
            // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 5, 1, 5, 5 }, 5)));  // 1,5,5
            // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
            // Console.WriteLine(string.Join(",", RemoveFirstOccurrence(new int[] { 5 }, 5)));           // (empty)

            // 8 Remove last occurrence of target
            // - remove only the last matching target value
            // Example: [1,5,10,5] Target: 5 => [1,5,10]
            // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 1, 5, 10, 5 }, 5))); // 1,5,10
            // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 5, 1, 5, 5 }, 5)));  // 5,1,5
            // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
            // Console.WriteLine(string.Join(",", RemoveLastOccurrence(new int[] { 5 }, 5)));           // (empty)

            // 9 Remove Last occurrence - Messing around
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 1, 5, 10, 5 }, 5))); // 1,5,10
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 5, 1, 5, 5 }, 5)));  // 5,1,5
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 1, 2, 3 }, 9)));     // 1,2,3
            // Console.WriteLine(string.Join(",", RemoveLastOccurrenceReverseForLoop(new int[] { 5 }, 5)));           // (empty)

            // Find last Number Greater Than Target
            //Console.WriteLine($"[1, 5, 10, 3], target 4 should return 10 => Answer: {FindLastNumberGreaterThanTarget([1, 5, 10, 3], 4)}");
            //Console.WriteLine($"[1, 2, 3], target 10 should return 0 => Answer: {FindLastNumberGreaterThanTarget([1, 2, 3], 10)}");
            //Console.WriteLine($"[-5, -2, 0], target -3 should return 0 => Answer: {FindLastNumberGreaterThanTarget([-5, -2, 0], -3)}");
            //Console.WriteLine($"[7], target 5 should return 7 => Answer: {FindLastNumberGreaterThanTarget([7], 5)}");
            //Console.WriteLine($"Empty array, target 5 should return 0 => Answer: {FindLastNumberGreaterThanTarget([], 5)}");
            //Console.WriteLine($"Null, target 5 should return 0 => Answer: {FindLastNumberGreaterThanTarget(null!, 5)}");

            // Find First Number Greater Than Target
            //Console.WriteLine($"[1, 5, 10, 3], target 4 should return 5 => Answer: {FindFirstNumberGreaterThanTarget([1, 5, 10, 3], 4)}");
            //Console.WriteLine($"[1, 2, 3], target 10 should return 0 => Answer: {FindFirstNumberGreaterThanTarget([1, 2, 3], 10)}");
            //Console.WriteLine($"[-5, -2, 0], target -3 should return -2 => Answer: {FindFirstNumberGreaterThanTarget([-5, -2, 0], -3)}");
            //Console.WriteLine($"[7], target 5 should return 7 => Answer: {FindFirstNumberGreaterThanTarget([7], 5)}");
            //Console.WriteLine($"Empty array, target 5 should return 0 => Answer: {FindFirstNumberGreaterThanTarget([], 5)}");
            //Console.WriteLine($"Null, target 5 should return 0 => Answer: {FindFirstNumberGreaterThanTarget(null!, 5)}");

            // Count Non Zeros: 
            //Console.WriteLine(CountNonZerosWarmUp([1, 0, 2, 0, 3])); // 3
            //Console.WriteLine(CountNonZerosWarmUp([0, 0, 0]));       // 0
            //Console.WriteLine(CountNonZerosWarmUp([1, 2, 3]));       // 3
            //Console.WriteLine(CountNonZerosWarmUp([]));               // 0

            // Rotate Array right by one:
            //Console.WriteLine(string.Join(",", RotateArrayRightByOne([1, 2, 3, 4]))); // 4,1,2,3
            //Console.WriteLine(string.Join(",", RotateArrayRightByOne([10, 20, 30]))); // 30,10,20
            //Console.WriteLine(string.Join(",", RotateArrayRightByOne([1])));          // 1
            //Console.WriteLine(string.Join(",", RotateArrayRightByOne([])));            // (empty)

            // Rotate Array left by one:
            //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([1, 2, 3, 4]))); // 2,3,4,1
            //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([10, 20, 30]))); // 20,30,10
            //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([1])));          // 1
            //Console.WriteLine(string.Join(",", RotateArrayLeftWarmUp([])));            // (empty)

            // Most Frequent Number:
            //Console.WriteLine(MostFrequentNumberInArrayRevision([1, 2, 2, 3, 2])); // 2
            //Console.WriteLine(MostFrequentNumberInArrayRevision([5, 5, 1, 1]));    // 5
            //Console.WriteLine(MostFrequentNumberInArrayRevision([9]));             // 9
            //Console.WriteLine(MostFrequentNumberInArrayRevision([]));               // 0

            // Count Negative Numbers:
            //Console.WriteLine($"[1, -2, 3, -4] should return [1, 3] => Answer: [{string.Join(", ", RemoveNegativeNumbers([1, -2, 3, -4]))}]");
            //Console.WriteLine($"[-1, -2, -3] should return [] => Answer: [{string.Join(", ", RemoveNegativeNumbers([-1, -2, -3]))}]");
            //Console.WriteLine($"[0, 1, 2] should return [0, 1, 2] => Answer: [{string.Join(", ", RemoveNegativeNumbers([0, 1, 2]))}]");
            //Console.WriteLine($"Empty array should return [] => Answer: [{string.Join(", ", RemoveNegativeNumbers([]))}]");
            //Console.WriteLine($"Null should return [] => Answer: [{string.Join(", ", RemoveNegativeNumbers(null!))}]");

            // Second largest Number Distinct
            //Console.WriteLine($"[10, 10, 5, 3] should return 5 => Answer: {FindSecondLargestDistinctNumber([10, 10, 5, 3])}");
            //Console.WriteLine($"[1, 5, 3, 9, 2] should return 5 => Answer: {FindSecondLargestDistinctNumber([1, 5, 3, 9, 2])}");
            //Console.WriteLine($"[30, 20, 10] should return 20 => Answer: {FindSecondLargestDistinctNumber([30, 20, 10])}");
            //Console.WriteLine($"[-5, -2, -1, -10] should return -2 => Answer: {FindSecondLargestDistinctNumber([-5, -2, -1, -10])}");
            //Console.WriteLine($"[10, 10] should return -1 => Answer: {FindSecondLargestDistinctNumber([10, 10])}");
            //Console.WriteLine($"[5, 5, 5] should return -1 => Answer: {FindSecondLargestDistinctNumber([5, 5, 5])}");
            //Console.WriteLine($"[100] should return -1 => Answer: {FindSecondLargestDistinctNumber([100])}");
            //Console.WriteLine($"Empty array should return -1 => Answer: {FindSecondLargestDistinctNumber([])}");
            //Console.WriteLine($"Null should return -1 => Answer: {FindSecondLargestDistinctNumber(null!)}");
        }
    }
}
