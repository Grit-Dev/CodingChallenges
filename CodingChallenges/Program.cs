using System.Text.Json;
using System.Text.Json.Serialization;
using CodingChallenges.Challenges.Phase_03_Practical_Challenges;

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

        public string Email { get; set; } = string.Empty;
    }

    public string RedactPersonalData_RunFour(string json)
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

        var jsonDeserialized = JsonSerializer.Deserialize<PersonData>(json, options);

        if (jsonDeserialized is null || jsonDeserialized.People == null)
        {
            return "";
        }

        foreach (var person in jsonDeserialized.People)
        {
            person.Name = NameRedaction_RunFour(person.Name);
            person.Address = "";
            person.Mobile = "";
            person.Email = "";
        }

        return JsonSerializer.Serialize(jsonDeserialized, options);

    }

    public string NameRedaction_RunFour(string name)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            return "";
        }

        string [] splitString = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if(splitString.Length == 1)
        {
            return splitString[0][0].ToString().ToUpper();
        }

        string firstName = splitString[0].ToString().ToUpper();
        string firstInitial = firstName[0].ToString();
        string secondName = splitString[splitString.Length -1].ToUpper();
        string secondInital = "";

        if(secondName.StartsWith("Mc", StringComparison.OrdinalIgnoreCase) && secondName.Length > 2)
        {
            secondInital = secondName[2].ToString().ToUpper();
        }
        else
        {
            secondInital = secondName[0].ToString().ToUpper();
        }

        return firstInitial + secondInital;
    }

    public static string AddressRedaction_RunFour(string address)
    {
        if(string.IsNullOrWhiteSpace(address))
        {
            return "";
        }

        string[] splitString = address.Split([','], StringSplitOptions.RemoveEmptyEntries);

        if(splitString.Length < 2)
        {
            return "";
        }

        return splitString[1].Trim();


    }
    public static void Main(string[] args)
    {
        // ChallengeSolutionsRunner.Run_Four();
        // JsonDataSanitizerRunner.Run();
    }

}
