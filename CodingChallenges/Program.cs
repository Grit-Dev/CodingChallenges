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
            person.Name = "";
            person.Address = "";
            person.Mobile = "";
            person.Email = "";
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
        if(string.IsNullOrWhiteSpace(address))
        {
            return "";
        }

        string [] splitString = address.Split([','], StringSplitOptions.RemoveEmptyEntries);

        if(splitString.Length < 2)
        {
            return "";
        }

        return splitString[1].Trim();

    }

    public static void Main(string[] args)
    {
        // ChallengeSolutionsRunner.Run_Three();
        // JsonDataSanitizerRunner.Run();
    }

}
