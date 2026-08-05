using System.Text.Json;

public class Program
{
    public class PeopleData
    {
        public List<People> Person { get; set; } = [];
    }
    public class People
    {
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
    public string RedactPersonalData(string json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return "";
        }

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var deserialized = JsonSerializer.Deserialize<PeopleData>(json, options);

        if (deserialized is null || deserialized.Person is null)
        {
            return "";
        }

        foreach (var person in deserialized.Person)
        {
            person.Name = NameRedaction(person.Name);
            person.Address = AddressRedaction(person.Address);
            person.Mobile = MobileNumberRedaction(person.Mobile);
            person.Email = EmailAddressRedaction(person.Email);
        }

        return JsonSerializer.Serialize(deserialized, options);

    }
    public static string NameRedaction(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            return "";
        }

        string[] splitString = fullName.Trim().Split(',', StringSplitOptions.RemoveEmptyEntries);

        if (splitString.Length == 0)
        {
            return "";
        }

        if (splitString.Length == 1)
        {
            return fullName[0].ToString();
        }

        string firstInitial = splitString[0][0].ToString();

        string secondName = splitString[1].Trim();

        string surnameInitial;

        if (secondName.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) &&
        secondName.Length > 2)
        {
            surnameInitial = secondName[2].ToString();
        }
        else
        {
            surnameInitial = secondName[0].ToString();
        }

        return firstInitial + surnameInitial;

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

    public static string MobileNumberRedaction(string mobileNumber)
    {
        if (string.IsNullOrWhiteSpace(mobileNumber))
        {
            return "";
        }

        mobileNumber = mobileNumber.Trim();

        if (mobileNumber.Length <= 4)
        {
            return mobileNumber;
        }

        int charactersLeftOver = mobileNumber.Length - 4;

        string asterisks = new('*', charactersLeftOver);

        string lastFourCharacters = mobileNumber.Substring(charactersLeftOver);

        return asterisks + lastFourCharacters;
    }

    public static string EmailAddressRedaction(string emailAddress)
    {
        if (string.IsNullOrWhiteSpace(emailAddress))
        {
            return "";
        }

        emailAddress = emailAddress.Trim();

        int indexOfAt = emailAddress.IndexOf('@');

        if (indexOfAt <= 0)
        {
            return "";
        }

        string asterisks = new('*', indexOfAt);

        string restOfEmail = emailAddress.Substring(indexOfAt);

        return asterisks + restOfEmail;
    }

    public static void Main(string[] args)
    {

        // NameRedaction
        Console.WriteLine(NameRedaction("Derek,Morgan") == "DM");
        Console.WriteLine(NameRedaction("Robert,McDowell") == "RD");
        Console.WriteLine(NameRedaction("Paul") == "P");
        Console.WriteLine(NameRedaction("") == "");

        // AddressRedaction
        Console.WriteLine(AddressRedaction("4321 Willow Lane, Edinburgh, EH12 7JQ") == "Edinburgh");
        Console.WriteLine(AddressRedaction("NoComma") == "");
        Console.WriteLine(AddressRedaction("") == "");

        // MobileNumberRedaction
        Console.WriteLine(MobileNumberRedaction("07700900832") == "*******0832");
        Console.WriteLine(MobileNumberRedaction("1234") == "1234");
        Console.WriteLine(MobileNumberRedaction("") == "");

        // EmailAddressRedaction
        Console.WriteLine(EmailAddressRedaction("derek.morgan@example.co.uk") == "************@example.co.uk");
        Console.WriteLine(EmailAddressRedaction("@example.co.uk") == "");
        Console.WriteLine(EmailAddressRedaction("invalidemail") == "");
        Console.WriteLine(EmailAddressRedaction("") == "");

        // ChallengeSolutionsRunner.Run_Three();
        // JsonDataSanitizerRunner.Run();
    }

}
