using System.Text.Json;

namespace CodingChallenges.Challenges.Phase_03_Practical_Challenges
{
    public class PersonalDataRedactor
    {
        public static string RedactPersonalData(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return "";
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase

            };

            PeopleData? deserializationOfJson = JsonSerializer.Deserialize<PeopleData>(json, options);

            if (deserializationOfJson is null || deserializationOfJson.People is null)
            {
                return "";
            }

            if (deserializationOfJson is null)
            {
                return "";
            }

            foreach (Person person in deserializationOfJson.People)
            {
                person.Name = NameRedaction(person.Name);
                person.Address = AddressRedaction(person.Address);
                person.Mobile = MobileNumberRedaction(person.Mobile);
                person.EmailAddress = EmailAddressRedaction(person.EmailAddress);
            }

            var serializationOfJson = JsonSerializer.Serialize(deserializationOfJson, options);

            return serializationOfJson;
        }
        private static string NameRedaction(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "";
            }

            string[] splitString = fullName.Split([' '], StringSplitOptions.RemoveEmptyEntries);

            if (splitString.Length == 0)
            {
                return "";
            }

            if (splitString.Length == 1)
            {
                return splitString[0][0].ToString().ToUpper();
            }

            string firstName = splitString[0];
            string surname = splitString[^1];

            char firstInitial = firstName[0];
            char surnameInitial;

            if (surname.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) &&
            surname.Length > 2)
            {
                surnameInitial = surname[2];
            }
            else
            {
                surnameInitial = surname[0];
            }

            return $"{char.ToUpper(firstInitial)}{char.ToUpper(surnameInitial)}";

        }

        private static string AddressRedaction(string houseAddress)
        {
            if (string.IsNullOrWhiteSpace(houseAddress))
            {
                return "";
            }

            string[] splitString = houseAddress.Split([','], StringSplitOptions.RemoveEmptyEntries);

            if (splitString.Length < 2)
            {
                return "";
            }

            return splitString[1].ToString().Trim();
        }

        private static string EmailAddressRedaction(string EmailAddress)
        {
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                return "";
            }

            var indexOfSpecialCharacter = EmailAddress.IndexOf('@');

            if (indexOfSpecialCharacter < 0)
            {
                return "";
            }

            var stringWithAsterisks = new string('*', indexOfSpecialCharacter);

            var restOfEmail = EmailAddress.Substring(indexOfSpecialCharacter);

            return stringWithAsterisks + restOfEmail;


        }

        private static string MobileNumberRedaction(string mobileNumber)
        {
            if (string.IsNullOrWhiteSpace(mobileNumber))
            {
                return "";
            }

            if (mobileNumber.Length <= 4)
            {
                return mobileNumber;
            }

            int remainingNumber = mobileNumber.Length - 4;

            var lastFourDigits = mobileNumber.Substring(remainingNumber);

            var asterisks = new string('*', remainingNumber);

            return asterisks + lastFourDigits;
        }
    }
}