using System.Text;

namespace CodingChallenges.Challenges
{
    public class ChallengeSolutions
    {
        public static int CountLettersCaseInsensitive(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int count = 0;

            foreach (char character in pInputValue)
            {
                if (char.IsLetter(character))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool AreAnagramsRevisionSat(string pInputValue, string pTarget)
        {
            if (pInputValue == null || pTarget == null)
            {
                return false;
            }

            if (pInputValue.Length != pTarget.Length)
            {
                return false;
            }

            int firstCounter = 0;
            int secondCounter = 0;

            pInputValue = pInputValue.ToLower();
            pTarget = pTarget.ToLower();

            for (int outterIndex = 0; outterIndex < pInputValue.Length; outterIndex++)
            {
                char currentChar = pInputValue[outterIndex];

                for (int innerIndex = 0; innerIndex < pInputValue.Length; innerIndex++)
                {
                    if (currentChar == pTarget[innerIndex])
                    {
                        firstCounter++;
                    }

                    if (pInputValue[innerIndex] == currentChar)
                    {
                        secondCounter++;
                    }
                }

                if (firstCounter != secondCounter)
                {
                    return false;
                }

                firstCounter = 0;
                secondCounter = 0;
            }

            return true;
        }

        public static string RemovePunctationAndSymbols(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            StringBuilder newString = new();

            foreach (char character in pInputValue)
            {
                if (char.IsLetterOrDigit(character) || char.IsWhiteSpace(character))
                {
                    newString.Append(character);
                }
            }

            return newString.ToString();
        }

        public static int CountWordsLongerThanTarget(string pInputValue, int pTarget)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int count = 0;
            string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in splitString)
            {
                if (word.Length > pTarget)
                {
                    count++;
                }
            }

            return count;
        }

        public static string CountEachLetterAToZRevision(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            int counter = 0;
            pInputValue = pInputValue.ToLower();
            StringBuilder newStringFromParameter = new();
            StringBuilder newStringReturnOutCome = new();
            List<char> newListOfChar = [];

            foreach (char character in pInputValue)
            {
                if (char.IsLetter(character))
                {
                    newStringFromParameter.Append(character);
                }
            }

            for (int outterIndex = 0; outterIndex < newStringFromParameter.Length; outterIndex++)
            {
                char currentChar = newStringFromParameter[outterIndex];

                if (!newListOfChar.Contains(currentChar))
                {
                    for (int innerIndex = 0; innerIndex < newStringFromParameter.Length; innerIndex++)
                    {
                        if (currentChar == newStringFromParameter[innerIndex])
                        {
                            counter++;
                        }
                    }

                    newListOfChar.Add(currentChar);

                    newStringReturnOutCome.Append(currentChar);
                    newStringReturnOutCome.Append(':');
                    newStringReturnOutCome.Append(counter);
                    newStringReturnOutCome.Append(' ');

                    counter = 0;
                }
            }

            return newStringReturnOutCome.ToString().Trim();
        }

        public static string FindMostFrequentWord(string pinputValue)
        {
            if (string.IsNullOrEmpty(pinputValue))
            {
                return "";
            }

            int counter = 0;
            int highestCount = 0;
            string wordHolder = "";

            pinputValue = pinputValue.ToLower();
            string[] stringspilit = pinputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string wordOutter in stringspilit)
            {
                foreach (string wordInner in stringspilit)
                {
                    if (wordOutter == wordInner)
                    {
                        counter++;
                    }
                }

                if (counter > highestCount)
                {
                    wordHolder = wordOutter;
                    highestCount = counter;
                }

                counter = 0;
            }

            return wordHolder;
        }

        public static int CountDigitsInString(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int counter = 0;

            foreach (char character in pInputValue)
            {
                if (char.IsDigit(character))
                {
                    counter++;
                }
            }

            return counter;
        }

        public static bool AreAnagramsRevisionFriday(string pInputValue, string pTarget)
        {
            if (pInputValue == null || pTarget == null)
            {
                return false;
            }

            if (pInputValue.Length != pTarget.Length)
            {
                return false;
            }

            pInputValue = pInputValue.ToLower();
            pTarget = pTarget.ToLower();
            int firstCounter = 0;
            int secondCounter = 0;

            for (int outterIndex = 0; outterIndex <= pInputValue.Length - 1; outterIndex++)
            {
                char currentChar = pInputValue[outterIndex];

                for (int innerIndex = 0; innerIndex <= pTarget.Length - 1; innerIndex++)
                {
                    if (currentChar == pTarget[innerIndex])
                    {
                        firstCounter++;
                    }

                    if (pInputValue[innerIndex] == currentChar)
                    {
                        secondCounter++;
                    }
                }

                if (firstCounter != secondCounter)
                {
                    return false;
                }

                firstCounter = 0;
                secondCounter = 0;
            }

            return true;
        }

        public static int CountUniqueCharacters(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int counter = 0;
            List<char> newList = new();
            pInputValue = pInputValue.ToLower();

            foreach (char character in pInputValue)
            {
                if (!newList.Contains(character))
                {
                    newList.Add(character);
                    counter++;
                }
            }

            return counter;
        }

        public static string RemovePunctuationOnly(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            StringBuilder newString = new();

            foreach (char character in pInputValue)
            {
                if (!char.IsPunctuation(character))
                {
                    newString.Append(character);
                }
            }

            return newString.ToString();
        }

        public static string KeepOnlyLettersAndSpaces(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            StringBuilder newString = new();

            foreach (char character in pInputValue)
            {
                if (char.IsLetter(character) || char.IsWhiteSpace(character))
                {
                    newString.Append(character);
                }
            }

            return newString.ToString();
        }

        public static string CountEachLetterAToZ(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            int counter = 0;
            StringBuilder passedParameterString = new();
            StringBuilder newStringFinal = new();
            List<char> newList = [];
            pInputValue = pInputValue.ToUpper();

            foreach (char character in pInputValue)
            {
                if (char.IsLetter(character))
                {
                    passedParameterString.Append(character);
                }
            }

            for (int outterIndex = 0; outterIndex <= passedParameterString.Length - 1; outterIndex++)
            {
                char currentChar = passedParameterString[outterIndex];

                if (!newList.Contains(currentChar))
                {
                    foreach (char characterInIndex in passedParameterString.ToString())
                    {
                        if (currentChar == characterInIndex)
                        {
                            newList.Add(currentChar);
                            counter++;
                        }
                    }

                    newStringFinal.Append(currentChar + ":");
                    newStringFinal.Append(counter);
                    newStringFinal.Append(' ');
                    counter = 0;
                }
            }

            return newStringFinal.ToString();

        }
        public static int CountSymbols(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int counter = 0;

            foreach (char character in pInputValue)
            {
                if (char.IsSymbol(character) || char.IsPunctuation(character))
                {
                    counter++;
                }
            }

            return counter;
        }

        // ChatGpt: We need to add this into the next phase please as missed a 
        // lot in this one.
        public static bool AreAnagrams(string pInputValue, string pTargetValue)
        {
            if (pInputValue == null || pTargetValue == null)
            {
                return false;
            }

            if (pInputValue.Length != pTargetValue.Length)
            {
                return false;
            }

            int firstCounter = 0;
            int secondCounter = 0;

            pInputValue = pInputValue.ToLower();
            pTargetValue = pTargetValue.ToLower();

            for (int outterIndex = 0; outterIndex <= pInputValue.Length - 1; outterIndex++)
            {
                char currentChar = pInputValue[outterIndex];

                for (int innerIndex = 0; innerIndex <= pTargetValue.Length - 1; innerIndex++)
                {
                    if (currentChar == pTargetValue[innerIndex])
                    {
                        firstCounter++;
                    }

                    if (pInputValue[innerIndex] == currentChar)
                    {
                        secondCounter++;
                    }
                }

                if (firstCounter != secondCounter)
                {
                    return false;
                }

                firstCounter = 0;
                secondCounter = 0;
            }

            return true;
        }

        public static int CountCharacterGroupsConsecutively(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int counter = 1;
            char previousCharacter = pInputValue[0];

            foreach (char character in pInputValue)
            {
                if (previousCharacter != character)
                {
                    counter++;
                }

                previousCharacter = character;
            }

            return counter;
        }

        public static string GetFirstLetters(string pinputValue)
        {
            if (string.IsNullOrEmpty(pinputValue))
            {
                return "";
            }

            StringBuilder newStringBuilder = new();
            string[] stringSplit = pinputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in stringSplit)
            {
                newStringBuilder.Append(word[0]);
            }

            return newStringBuilder.ToString();
        }

        public static string GetLastLetters(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            StringBuilder newStringBuilder = new();
            string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in stringSplit)
            {
                newStringBuilder.Append(word[^1]);
            }

            return newStringBuilder.ToString();


        }

        // Revision Test:
        //public static int CountUniqueCharacters(string pInputValue)
        //{
        //    if (string.IsNullOrEmpty(pInputValue))
        //    {
        //        return 0;
        //    }

        //    List<char> newList = [];
        //    int counter = 0;
        //    pInputValue = pInputValue.ToLower();

        //    foreach (char character in pInputValue)
        //    {
        //        if (!newList.Contains(character))
        //        {
        //            newList.Add(character);
        //            counter++;
        //        }
        //    }

        //    return counter;
        //}
        public static int CountPunctuationCharacters(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int count = 0;

            foreach (char character in pInputValue)
            {
                if (char.IsPunctuation(character))
                {
                    count++;
                }
            }

            return count;
        }

        // Bit more revision on this one. 
        public static string RemoveConsecutiveDuplicateCharacters(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }


            StringBuilder newString = new();
            char previousCharacter = pInputValue[0];
            newString.Append(previousCharacter);

            foreach (char currentChar in pInputValue)
            {
                if (currentChar != previousCharacter)
                {
                    newString.Append(currentChar);
                    previousCharacter = currentChar;
                }

            }

            return newString.ToString();
        }

        public static bool AreAnagramsRevision(string pInputValue, string pTargetValue)
        {
            if (pInputValue == null || pTargetValue == null)
            {
                return false;
            }

            if (pInputValue == "" && pTargetValue == "")
            {
                return true;
            }

            if (pInputValue.Length != pTargetValue.Length)
            {
                return false;
            }

            pInputValue = pInputValue.ToLower();
            pTargetValue = pTargetValue.ToLower();

            int firstValueCounter = 0;
            int secondValueCounter = 0;

            for (int outterIndex = 0; outterIndex <= pInputValue.Length - 1; outterIndex++)
            {
                char value = pInputValue[outterIndex];

                for (int innerIndex = 0; innerIndex <= pTargetValue.Length - 1; innerIndex++)
                {
                    if (value == pTargetValue[innerIndex])
                    {
                        firstValueCounter++;
                    }

                    if (pInputValue[innerIndex] == value)
                    {
                        secondValueCounter++;
                    }
                }

                if (firstValueCounter != secondValueCounter)
                {
                    return false;
                }

                firstValueCounter = 0;
                secondValueCounter = 0;
            }

            return true;
        }

        public static int CountCharacterGroups(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int counter = 1;
            char previousCharacter = pInputValue[0];

            foreach (char currentChar in pInputValue)
            {
                //aabbc
                if (currentChar != previousCharacter)
                {
                    counter++;
                    previousCharacter = currentChar;
                }

            }

            return counter;
        }

        public static string GetInitials(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            pInputValue = pInputValue.ToUpper();
            string[] splitString = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder newStringBuilder = new();

            foreach (string word in splitString)
            {
                newStringBuilder.Append(word[0]);
            }

            return newStringBuilder.ToString();
        }

        public static bool IsPangram(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return false;
            }

            char[] letters =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };

            int counter = 0;
            pInputValue = pInputValue.ToUpper();

            for (int outterIndex = 0; outterIndex <= letters.Length - 1; outterIndex++)
            {
                char currentChar = letters[outterIndex];

                foreach (char character in pInputValue)
                {
                    if (currentChar == character)
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    return false;
                }

                counter = 0;
            }

            return true;
        }
        public static bool AreStringsAnagrams(string pInputValue, string pInputValueComparison)
        {
            if (pInputValue == null || pInputValueComparison == null)
            {
                return false;
            }

            if (pInputValue == "" && pInputValueComparison == "")
            {
                return true;
            }

            if (pInputValue.Length != pInputValueComparison.Length)
            {
                return false;
            }

            int firstValueCount = 0;
            int secondValueCount = 0;

            pInputValue = pInputValue.ToLower();
            pInputValueComparison = pInputValueComparison.ToLower();

            for (int outerIndex = 0; outerIndex < pInputValueComparison.Length; outerIndex++)
            {
                char currentChar = pInputValue[outerIndex];

                for (int innerIndex = 0; innerIndex < pInputValueComparison.Length; innerIndex++)
                {

                    if (pInputValueComparison[innerIndex] == currentChar)
                    {
                        firstValueCount++;
                    }

                    if (pInputValue[innerIndex] == currentChar)
                    {
                        secondValueCount++;
                    }
                }

                if (firstValueCount != secondValueCount)
                {
                    return false;
                }

                firstValueCount = 0;
                secondValueCount = 0;

            }



            return true;

        }

        public static int CountCharactersExceptSpaces(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int count = 0;

            foreach (char character in pInputValue)
            {
                if (!char.IsWhiteSpace(character))
                {
                    count++;
                }
            }

            return count;
        }

        public static string FindFirstNonRepeatingCharacter(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "_";
            }

            int count = 0;

            for (int outterIndex = 0; outterIndex < pInputValue.Length; outterIndex++)
            {
                char character = pInputValue[outterIndex];

                foreach (char characterTwo in pInputValue)
                {
                    if (characterTwo == character)
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    return character.ToString();
                }

                count = 0;
            }

            return "_";
        }

        public static char FindLastNonRepeatingCharacter(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return '_';
            }

            int counter = 0;

            for (int outterIndex = pInputValue.Length - 1; outterIndex >= 0; outterIndex--)
            {
                char character = pInputValue[outterIndex];

                for (int innerIndex = pInputValue.Length - 1; innerIndex >= 0; innerIndex--)
                {
                    if (character == pInputValue[innerIndex])
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    return character;
                }

                counter = 0;
            }

            return '_';
        }
        public static int CountWordOccurrences(string pInputValue, string pTargetString)
        {
            if (string.IsNullOrEmpty(pInputValue) || string.IsNullOrEmpty(pTargetString))
            {
                return 0;
            }

            int counter = 0;
            pInputValue = pInputValue.ToLower();
            pTargetString = pTargetString.ToLower();
            string[] stringSplit = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in stringSplit)
            {
                if (pTargetString == word)
                {
                    counter++;
                }
            }

            return counter;

        }

        public static int CountLettersOnly(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return 0;
            }

            int counter = 0;

            foreach (char character in pInputValue)
            {
                if (char.IsLetter(character))
                {
                    counter++;
                }
            }

            return counter;
        }

        //public static char FindFirstNonRepeatingCharacter(string pInputValue)
        //{
        //    if (string.IsNullOrEmpty(pInputValue))
        //    {
        //        return '_';
        //    }

        //    for (int outerIndex = 0; outerIndex <= pInputValue.Length - 1; outerIndex++)
        //    {
        //        int counter = 0;
        //        char value = char.ToLower(pInputValue[outerIndex]);

        //        for (int innerIndex = 0; innerIndex <= pInputValue.Length - 1; innerIndex++)
        //        {
        //            if (value == pInputValue[innerIndex])
        //            {
        //                counter++;
        //            }
        //        }

        //        if (counter == 1)
        //        {
        //            return value;
        //        }
        //    }

        //    return '_';
        //}

        public static string RemoveDuplicateCharactersPreserveOrder(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            List<char> charactersList = [];
            StringBuilder stringBuilder = new();

            foreach (char character in pInputValue)
            {
                if (!charactersList.Contains(character))
                {
                    charactersList.Add(character);
                    stringBuilder.Append(character);
                }
            }

            return stringBuilder.ToString();
        }

        public static string FindLongestWord(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            var splitWords = pInputValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int longestCount = 0;
            string longestWord = "";

            foreach (string word in splitWords)
            {
                int count = 0;

                foreach (char character in word)
                {
                    count++;
                }

                if (count > longestCount)
                {
                    longestCount = count;
                    longestWord = word;
                }
            }

            return longestWord;

        }

        public static string CompressConsecutiveRepeatedCharacters(string pInputValue)
        {
            if (string.IsNullOrEmpty(pInputValue))
            {
                return "";
            }

            StringBuilder stringBuilder = new();
            int counter = 0;
            char currentChar = pInputValue[0]; ;

            for (int outerIndex = 0; outerIndex <= pInputValue.Length - 1; outerIndex++)
            {
                if (currentChar == pInputValue[outerIndex])
                {
                    counter++;
                }
                else
                {
                    stringBuilder.Append(currentChar);
                    stringBuilder.Append(counter);

                    currentChar = pInputValue[outerIndex];
                    counter = 1;
                }

            }

            stringBuilder.Append(currentChar);
            stringBuilder.Append(counter);

            return stringBuilder.ToString();
        }

        // Revision Test:
        //public static int CountDigitsInString(string pInputValue)
        //{
        //    if (string.IsNullOrEmpty(pInputValue))
        //    {
        //        return 0;
        //    }

        //    int count = 0;

        //    foreach (char character in pInputValue)
        //    {
        //        if (char.IsDigit(character))
        //        {
        //            count++;
        //        }
        //    }

        //    return count;
        //}

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

        public static string RemoveVowels(string pInputValue)
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

        public static string CountVowelsAndConsonants(string pInputvalue)
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

        public int CountDigitsFromString(string pInputValue)
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

        public string ReverseString(string pInputValue)
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

        public int CountingVowels(string pInputValue)
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

        public bool IsPalindrome(string pInputValue)
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

        public int LargestNumber(int[] pInput)
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

        public int SumEvenNumbers(int[] pInput)
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

        public int CountingSpaces(string pInputValue)
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

        public int CountingCapitalLetters(string pInputValue)
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

        public int CountingWords(string pInputValue)
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

        public int SmallestNumber(int[]? pInputValue)
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

        public string CountVowelsAndConsonantsFriday(string pInputValue)
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

        public int CharacterOccurrences(string? pInputValue, char pTargetCharacter)
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

        public int[] TwoSum(int[] pNums, int pTarget)
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

/*        public static char FindFirstNonRepeatingCharacter(string pInputeValue)
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
*/
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

        public static string CountVowelsAndConsonantsRev(string pInputvalue)
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
    }
}
