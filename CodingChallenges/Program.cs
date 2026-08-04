using CodingChallenges.Challenges.Phase_03_Practical_Challenges;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Numerics;
using System.Text.Json;

public class Program
{
    public class PersonData
    {
        public List<Person> People { get; set; } = [];
    }
    public class Person
    {
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;
    }

    public static string NameRedaction(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "";
        }

        string[] splitString = name.Split([' '], StringSplitOptions.RemoveEmptyEntries);

        if (splitString.Length == 1)
        {
            return splitString[0][0].ToString().Trim().ToUpper();
        }

        string firstName = splitString[0][0].ToString().ToUpper();

        string secondName = splitString[1];

        if (secondName.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) && secondName.Length > 2)
        {
            secondName = secondName[2].ToString().ToUpper();
        }
        else
        {
           secondName = secondName[0].ToString().ToUpper();
        }

        return firstName + secondName;
    }

    public static string AddressRedaction(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            return "";
        }

        string[] splitString = address.Split([','], StringSplitOptions.RemoveEmptyEntries);

        if (splitString.Length < 2)
        {
            return "";
        }

        return splitString[1].Trim();
    }

    public static string RedactPersonalData(string json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return "";
        }

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };

        var jsonDeserialized = JsonSerializer.Deserialize<PeopleData>(json, options);

        if (jsonDeserialized == null || jsonDeserialized.People.Count == 0)
        {
            return "";
        }

        foreach (var person in jsonDeserialized.People)
        {
            person.Name = NameRedaction(person.Name);
            person.Address = AddressRedaction(person.Address);
            person.Mobile = MobileNumberRedaction(person.Mobile);
            person.EmailAddress = "";
        }

        var jsonSerialized = JsonSerializer.Serialize(jsonDeserialized);

        return jsonSerialized;
    }

    public static string MobileNumberRedaction(string mobileNumber)
    {
        if (string.IsNullOrWhiteSpace(mobileNumber))
        {
            return "";
        }

        if (mobileNumber.Length <= 4)
        {
            return mobileNumber;
        }

        int charactersLeftOver = mobileNumber.Length - 4;

        string asterisks = new('*', charactersLeftOver);

        string lastFourCharacters = mobileNumber.Substring(charactersLeftOver);

        return asterisks + lastFourCharacters;
    }

    public static string EmailAddressRedaction(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            return "";
        }

        int indexOfSpecialCharacter = address.IndexOf('@');

        if (indexOfSpecialCharacter < 0)
        {
            return "";
        }

        string everythingBeforeAt = new ('*', indexOfSpecialCharacter);

        string remainingEmailAddress = address.Substring(indexOfSpecialCharacter);

        return everythingBeforeAt + remainingEmailAddress;
    }
    public static void Main(string[] args)
    {

        Console.WriteLine("=== EmailAddressRedaction Tests ===");
        Console.WriteLine(EmailAddressRedaction("derek.morgan@example.co.uk") == "************@example.co.uk");
        Console.WriteLine(EmailAddressRedaction("robert.mcdowell@test.com") == "***************@test.com");
        Console.WriteLine(EmailAddressRedaction("derek@example.co.uk") == "*****@example.co.uk");
        Console.WriteLine(EmailAddressRedaction("invalidEmail") == "");
        Console.WriteLine(EmailAddressRedaction("") == "");
        Console.WriteLine(EmailAddressRedaction("   ") == "");

        //Console.WriteLine("=== MobileNumberRedaction Tests ===");
        //Console.WriteLine(MobileNumberRedaction("07700900832") == "*******0832");
        //Console.WriteLine(MobileNumberRedaction("07123456789") == "*******6789");
        //Console.WriteLine(MobileNumberRedaction("1234") == "1234");
        //Console.WriteLine(MobileNumberRedaction("123") == "123");
        //Console.WriteLine(MobileNumberRedaction("") == "");
        //Console.WriteLine(MobileNumberRedaction("   ") == "");

        //Console.WriteLine("=== MobileNumberRedaction Tests ===");
        //Console.WriteLine(AddressRedaction("4321 Willow Lane, Edinburgh, EH12 7JQ") == "Edinburgh");
        //Console.WriteLine(AddressRedaction("12 Main Street, Belfast, BT1 1AA") == "Belfast");
        //Console.WriteLine(AddressRedaction("Flat 4, Derry, BT48 6AA") == "Derry");
        //Console.WriteLine(AddressRedaction("No commas here") == "");
        //Console.WriteLine(AddressRedaction("") == "");
        //Console.WriteLine(AddressRedaction("   ") == "");

        //Console.WriteLine("=== NameRedaction Tests ===");
        //Console.WriteLine(NameRedaction("Derek Morgan") == "DM");
        //Console.WriteLine(NameRedaction("Robert McDowell") == "RD");
        //Console.WriteLine(NameRedaction("Robert mcdowell") == "RD");
        //Console.WriteLine(NameRedaction("Derek") == "D");
        //Console.WriteLine(NameRedaction("  Derek   Morgan  ") == "DM");
        //Console.WriteLine(NameRedaction("Mary Smith") == "MS");
        //Console.WriteLine(NameRedaction("") == "");
        //Console.WriteLine(NameRedaction("   ") == "");

        //JsonDataSanitizerRunner.Run();
    }

}
 